<?php
/**
 * Zend Framework (http://framework.zend.com/)
 *
 * @link      http://github.com/zendframework/ZendSkeletonApplication for the canonical source repository
 * @copyright Copyright (c) 2005-2014 Zend Technologies USA Inc. (http://www.zend.com)
 * @license   http://framework.zend.com/license/new-bsd New BSD License
 */

namespace Application;

use Zend\Mvc\ModuleRouteListener;
use Zend\Mvc\MvcEvent;

class ErrorHandlingService
{
	protected $logger;

	function __construct($logger)
	{
		$this->logger = $logger;
	}

	function logException(\Exception $e)
	{
		$trace = $e->getTraceAsString();
		$i = 1;
		do {
			$messages[] = $i++ . ": " . $e->getMessage();
		} while ($e = $e->getPrevious());

		$log = "\nException:n" . implode("n", $messages);
		$log .= "\nnTrace:n". "\n" . $trace;

		$this->logger->warn($log);
	}
	function logError($error)
	{
// 		$trace = $e->getTraceAsString();
// 		$i = 1;
// 		do {
// 			$messages[] = $i++ . ": " . $e->getMessage();
// 		} while ($e = $e->getPrevious());
	
// 		$log = "Error:n" . implode("n", $messages);
// 		$log .= "nTrace:n" . $trace;
		$log = "\nError: " . $error['type']
				."\Message: ".$error['message']
				."\nFile: ".$error['file']."on line number: ". $error['line'];
	
		$this->logger->err($log);
	}
}
class Module
{
    public function onBootstrap(MvcEvent $e)
    {
        $eventManager        = $e->getApplication()->getEventManager();
        $moduleRouteListener = new ModuleRouteListener();
        $moduleRouteListener->attach($eventManager);
		
        //add for log
        $eventManager->attach('dispatch.error', function($event){
        	$exception = $event->getResult()->exception;  
        	$error = error_get_last();
        	if ($exception) {
        		$sm = $event->getApplication()->getServiceManager();
        		$service = $sm->get('ApplicationServiceErrorHandling');
        		$service->logException($exception);
        	}
        	if(true){
        		$sm = $event->getApplication()->getServiceManager();
        		$service = $sm->get('ApplicationServiceErrorHandling');				
        		$service->logError($error);
        	}
        });
        //end
    }
    
    public function getServiceConfig()
    {
    	return array(
    			'factories' => array(
    					'ApplicationServiceErrorHandling' =>  function($sm) {
    						$logger = $sm->get('ZendLog');
    						$service = new ErrorHandlingService($logger);
    						return $service;
    					},
    					'ZendLog' => function ($sm) {
    						$filename = 'log_' . date('F') . '.txt';
    						$log = new \Zend\Log\Logger();
    						$stream = fopen('D:/log.txt', 'a+');
    						$writer = new \Zend\Log\Writer\Stream($stream);
    						$log->addWriter($writer);
    
    						return $log;
    					},
    			),
    	);
    }
    
    public function bootstrapSession($e)
    {
        $session = $e->getApplication()
                     ->getServiceManager()
                     ->get('Zend\Session\SessionManager');
        $session->start();

        $container = new Container('initialized');
        if (!isset($container->init)) {
             $session->regenerateId(true);
             $container->init = 1;
        }
    }
    public function getConfig()
    {
        return include __DIR__ . '/config/module.config.php';
    }

    public function getAutoloaderConfig()
    {
        return array(
            'Zend\Loader\StandardAutoloader' => array(
                'namespaces' => array(
                    __NAMESPACE__ => __DIR__ . '/src/' . __NAMESPACE__,
                ),
            ),
            //add for session
//            'Zend\Session\SessionManager' => function ($sm) {
//                    $config = $sm->get('config');
//                    if (isset($config['session'])) {
//                        $session = $config['session'];
//
//                        $sessionConfig = null;
//                        if (isset($session['config'])) {
//                            $class = isset($session['config']['class'])  ? $session['config']['class'] : 'Zend\Session\Config\SessionConfig';
//                            $options = isset($session['config']['options']) ? $session['config']['options'] : array();
//                            $sessionConfig = new $class();
//                            $sessionConfig->setOptions($options);
//                        }
//
//                        $sessionStorage = null;
//                        if (isset($session['storage'])) {
//                            $class = $session['storage'];
//                            $sessionStorage = new $class();
//                        }
//
//                        $sessionSaveHandler = null;
//                        if (isset($session['save_handler'])) {
//                            // class should be fetched from service manager since it will require constructor arguments
//                            $sessionSaveHandler = $sm->get($session['save_handler']);
//                        }
//
//                        $sessionManager = new SessionManager($sessionConfig, $sessionStorage, $sessionSaveHandler);
//
//                        if (isset($session['validators'])) {
//                            $chain = $sessionManager->getValidatorChain();
//                            foreach ($session['validators'] as $validator) {
//                                $validator = new $validator();
//                                $chain->attach('session.validate', array($validator, 'isValid'));
//
//                            }
//                        }
//                    } else {
//                        $sessionManager = new SessionManager();
//                    }
//                    Container::setDefaultManager($sessionManager);
//                    return $sessionManager;
//                },
            //end for session
        );
    }
}
