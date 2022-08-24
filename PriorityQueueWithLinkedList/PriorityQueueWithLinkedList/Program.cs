using PriorityQueueWithLinkedList;

var queue = new PriorityQueue();

queue.Enqueue(4, 1);
queue.Enqueue(3, 10);
queue.Dequeue();
queue.Print();
queue.Enqueue(2, 100);
queue.Enqueue(1, 1000);
queue.Dequeue();
queue.Dequeue();


