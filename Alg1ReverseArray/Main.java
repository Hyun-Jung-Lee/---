import java.lang.reflect.Array;
import java.util.Arrays;

public class Main {

    public static void main(String[] args) {
	// write your code here
        System.out.println("Hello!");
        int[] arr= {1,2,3,4,5,6,7,8,9};
        System.out.println(Arrays.toString(arr));

        int l=0, r=arr.length-1;
        int temp;
        while (l<r){
            temp = arr[l];
            arr[l] = arr[r];
            arr[r] = temp;
            l++;
            r--;
        }
        System.out.println("After Reverse:");
        System.out.println(Arrays.toString(arr));
    }
}
