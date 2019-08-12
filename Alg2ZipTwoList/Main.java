//Combine two list on-site.

import java.lang.reflect.Array;
import java.util.LinkedList;
import java.util.List;

public class Main {

    public static void main(String[] args) {

        int[] listArray1 = new int[]{1, 3, 5, 7, 7, 9,10};
        int[] listArray2 = new int[]{2, 6, 7, 8};
        //convert array to node link list
        Node list1 = makeList(listArray1);
        printList(list1);

        Node list2 = makeList(listArray2);
        printList(list2);

        Node result = zipTwoList(list1, list2);
        printList(result);


    }

    private static Node zipTwoList(Node p, Node q) {
        Node head = new Node();
        Node current = head;
        while(p!=null && q!=null){
            if (p.val <= q.val){
                current.next=p;
                p = p.next;
            }
            else{
                current.next=q;
                q=q.next;
            }
            current = current.next;
        }

        // deal with longer list
        if(p == null){
            current.next = q;
        }
        else{
            current.next = p;
        }


        return head.next;

    }

    private static void printList(Node list) {


        while (list !=null){
            System.out.print(list.val + "->");
            list = list.next;
        }
        System.out.println();
    }

    private static Node makeList(int[] a) {
        Node head = null;
        for(int i=a.length-1; i>=0; i--){
            Node temp = new Node();
            temp.val=a[i];
            temp.next=head;
            head = temp;
        }

        return head;
    }
}
