# C# Multithreading
This project provides example of execution multiple tasks or processes over a certain time interval.


### System.Threading 
*Some commonly used classes in this namespace* 

| **Mutex** | It is a synchronization primitive that can also be used for IPS (interprocess synchronization). |
|--|--|
| **Monitor** |  This class provides a mechanism that access objects in synchronize manner.|
| **Semaphore** |  This class is used to limit the number of threads that can access a resource or pool of resources concurrently.|
| **Thread** |  This class is used to creates and controls a thread, sets its priority, and gets its status.|
| **ThreadPool** | This class provides a pool of threads that can be used to execute tasks, post work items, process asynchronous I/O, wait on behalf of other threads, and process timers.|
| **ThreadLocal** |  This class provides thread-local storage of data.|
| **Timer** |  This class provides a mechanism for executing a method on a thread pool thread at specified intervals. You are not allowed to inherit this class.|
| **Volatile** |  This class contains methods for performing volatile memory operations.|



### Important Points

-   A  **deadlock** can occur if the thread that calls Abort methods holds a lock that the aborted thread requires.
-   If the  _Abort_ method is called on a thread which has not been started, then that thread will abort when Start is called.
-   If the  _Abort_ method is called on a thread which is blocked or is sleeping then the thread will get interrupted and after that get aborted.
-   If  _Abort_ method is called on a suspended thread then a  `ThreadStateException` is thrown in the thread that called Abort, and  _AbortRequested_ is added to the  _ThreadState_ property of the thread being aborted.
-   A  _ThreadAbortException_ is not thrown in the suspended thread until  _Resume_ is called.
-   If the  _Abort_ method is called on a Managed thread which is currently executing unmanaged code then a  `ThreadAbortException` is not thrown until the thread returns to managed code.
-   If two calls to  _Abort_ come at the same time then it is possible for one call to set the state information and the other call to execute the Abort. But, an application cannot detect this situation.
-   After  _Abort_ is called on a thread, the state of the thread includes  _AbortRequested_. After the thread has terminated due to the result of a successful call to Abort, the state of the thread is changed to Stopped. With sufficient permissions, a thread which is the target of an  _Abort_ can cancel the abort using the  _ResetAbort_ method.
push image to registry
