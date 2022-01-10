
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

### Life Cycle of a thread

- **Unstarted state:** When an instance of a Thread class is created, it is in the unstarted state, means the thread has not yet started to run when the thread is in this state. Or in other words _Start()_ method is not called.
- **Runnable State:** A thread that is ready to run is moved to runnable state. In this state, a thread might actually be running or it might be ready to run at any instant of time. It is the responsibility of the thread scheduler to give the thread, time to run. Or in other words, the  _Start()_  method is called.  
    
- **Running State:** A thread that is running. Or in other words, the thread gets the processor.
- **Not Runnable State:** A thread that is not executable because
    -   Sleep() method is called.
    -   Wait() method is called.
    -   Due to I/O request.
    -   Suspend() method is called.
- **Dead State:**  When the thread completes its task, then thread enters into dead, terminates, abort state.

### # Join & IsAlive
The Join method of Thread class in C# blocks the current thread and makes it wait until the child thread on which the Join method invoked completes its execution.

    public void Join();
    public void Join(int millisecondsTimeout);
    public void Join(TimeSpan timeout);

> The first version of the Join method which does not take any parameter will block the calling thread (i.e. the Parent thread) until the thread (child thread) completes its execution. 

> The second version of the Join Method allows us to specify the time out. It means it will block the calling thread until the child thread terminates or the  specified time elapses.

The IsAlive method of Thread class returns true if the thread is still executing else returns false.
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
