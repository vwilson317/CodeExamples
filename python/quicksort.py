def quickSort(array, start, end):
    if start < end:
        split = partition(array, start, end)
        quickSort(array, start, split-1)
        quickSort(array, split+1, end)

def partition(array, start, end):
    pivot = array[end]
    bottom = start - 1
    top = end

    while not bottom == top:
        if(array[top] > pivot):
            array[top] = array[bottom]

    while not top == bottom:
        if(array[top] < pivot):
            array[bottom] = array[top]

    array[top] = pivot
    return pivot

if __name__=="__main__":  
    myArray = [33, 5, 83, 73, 101, 10, 2]

    quickSort(myArray, 0 , 6)

    print(myArray)