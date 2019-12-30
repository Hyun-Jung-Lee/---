
def bubbleSort(list):
    unsort_index = len(list) -1
    unsort = True
    while(unsort):
        for i in range(unsort_index):
            unsort = False
            if list[i]>list[i+1]:
                unsort = True
                #swith
                temp = list[i+1]
                list[i+1] = list[i]
                list[i] = temp
        # after loop, max value change to rightest position
        unsort_index = unsort_index -1 # keep decrease right index


if __name__ == '__main__':
    list = [2, 10 , 6, 8, 9]
    print("Before sort:")
    print(list)
    print("")
    bubbleSort(list)
    print("After sort:")
    print(list)

