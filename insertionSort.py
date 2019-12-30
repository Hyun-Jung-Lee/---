def insertionSort(list):
    for i in range (1, len(list)):
        position = i # pick second left as temp value
        temp_mini = list[i]
        #when left of poisiton is not negative; compare left value to temp value.
        #make sure all left value small than temp value
        while (position-1)>=0 and temp_mini < list[position-1]:
            # shift value of position -1 to position
            list[position] = list[position-1]
            # set position-1 as current positioni
            position = position -1
        # after loop,set temp_mini value to position
        list[position]=temp_mini




if __name__ == '__main__':
    list = [2, 10 , 6, 8, 9]
    print("Before sort:")
    print(list)
    print("")
    insertionSort(list)
    print("After sort:")
    print(list)
