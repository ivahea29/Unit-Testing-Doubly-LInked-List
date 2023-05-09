namespace DoublyLinkedListWithErrors
{
    public class DLList
    {
        public DLLNode head; // pointer to the head of the list
        public DLLNode tail; // pointer to the tail of the list
        public DLList() { head = null; tail = null; } // constructor
        /*-------------------------------------------------------------------
        * The methods below includes several errors. Your  task is to write
        * unit test to discover these errors. During delivery the tutor may
        * add or remove errors to adjust the scale of the effort required by
        */
        // Add To Tail
        public void addToTail(DLLNode p)
        {
            if (head == null) // If the list is empty
            {
                head = p; // head and tail pointers both point to the first node
                tail = p;
            }
            else // If the list is not empty
            {
                tail.next = p; // link the new node to the end of the list
                p.previous = tail; // link the new node back to the previous last node
                tail = p; // update the tail pointer to point to the new last node
            }
        } // end of addToTail
        // Add to Head
        public void addToHead(DLLNode p)
        {
            if (head == null) // If the list is empty
            {
                head = p; // head and tail pointers both point to the first node
                tail = p;
            }
            else // If the list is not empty
            {
                p.next = head; // link the new node to the beginning of the list
                head.previous = p; // link the new node back to the previous first node
                head = p; // update the head pointer to point to the new first node
            }
        } // end of addToHead
        public void removeHead()
        {
            if (head == null) 
            return; // if the list is empty, return
            head = head.next; // make the head pointer point to the next node
            if (head != null) head.previous = null; // if the next node exists, update its previous pointer to null
            else tail = null; // if the next node does not exist, the list is empty, so update the tail pointer to null
        } // removeHead
          // Remove Tail
        public void removeTail()
        {
            if (tail == null) return; // if the list is empty, return
            if (head == tail) // if there is only one node in the list
            {
                head = null; // update head and tail pointers to null
                tail = null;
            }
            else // if there are multiple nodes in the list
            {
                tail = tail.previous; // update the tail pointer to point to the previous node
                tail.next = null; // update the next pointer of the new last node to null
            }
        } // remove tail
        /*-------------------------------------------------
         * Return null if the string does not exist.
         * ----------------------------------------------*/
        // Search List
        public DLLNode search(int num)
        {
            DLLNode p = head; // start from the beginning of the list
            while (p != null && p.num != num) // loop until the end of the list or the node with the specified number is found
            {
                p = p.next; // move to the next node
            }
            return p; // return the found node or null if the node is not found
        } // end of search (return pointer to the node)
        // Remove from List
        public void removeNode(DLLNode p)
        { // removing the node p.
            if (p.next == null)
            {   // If p is the tail node
                tail = tail.previous;   // Move tail back to the previous node
                tail.next = null;   // Remove the reference to the old tail node
            }
            else if (p.previous == null)
            {   // If p is the head node
                head = head.next;   // Move head forward to the next node
                head.previous = null;   // Remove the reference to the old head node00020
            }
            else
            {   // If p is neither the head nor tail node
                p.next.previous = p.previous;   // Connect the previous node of p to the next node of p
                p.previous.next = p.next;   // Connect the next node of p to the previous node of p
            }
            p.next = null;   // Remove the reference to the next node of p
            p.previous = null;   // Remove the reference to the previous node of p
        } // end of remove a node
          // Total
        public int total()
        {
            DLLNode p = head;   // Initialize a new node p to the head of the linked list
            int tot = 0;   // Initialize a new variable tot to 0
            while (p != null)
            {   // Iterate through the linked list until the end
                tot += p.num;   // Add the value of the current node to the total
                p = p.next;   // Move to the next node in the list
            }
            return tot;   // Return the total value
        } // end of total
        
    }
}
