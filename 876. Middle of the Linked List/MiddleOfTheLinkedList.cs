
// Test case
// head = { 1, 2, 3, 4, 5}
var head = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));
ListNode theMiddle = ListNode.MiddleNode(head);
Console.WriteLine(theMiddle.val);

class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode? next = null) {
        this.val = val;
        this.next = next;
    }
    public static ListNode MiddleNode(ListNode head) {
        int count = 0;
        int selection;
        ListNode pointer = head;
        for (; pointer != null; pointer = pointer.next) {
            count += 1;
        }
        if (count % 2 == 0) {
            selection = count / 2;
        } else {
            selection = (count - 1) / 2;
        }
        count = 0;
        pointer = head;
        while (count != selection) {
            count++;
            pointer = pointer.next;
        }
        return pointer;
    }
}
