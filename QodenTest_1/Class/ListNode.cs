using System;
using System.Collections.Generic;

namespace QodenTest_1.Class
{
    public class ListNode
    {
        public int value;
        public ListNode next;

        public ListNode(int value)
        {
            this.value = value;
            next = null;
        }

        public void Insert(int newValue)
        {
            ListNode newNode = new ListNode(newValue);
            newNode.next = next;
            next = newNode;
        }
    }
}
