def quickSort(array, start, end):
    if(start < end):
        partitionIndex = partition(array, start, end)
        quickSort(array, partitionIndex + 1, end) 
        quickSort(array,  start, partitionIndex - 1) 

def partition(array, partitionIndex, end):
    endVal = array[end]

    for index, currentVal in enumerate(array):
        partitionVal = array[partitionIndex]
        
        if index >= partitionIndex:
            if(currentVal < endVal):
                array[partitionIndex] = currentVal
                array[index] = partitionVal
                partitionIndex += 1
        

    array[end] = array[partitionIndex]
    array[partitionIndex] = endVal
    return partitionIndex
    

if __name__=="__main__":  
    myArray = [33, 5, 83, 73, 101, 10, 2]

    quickSort(myArray, 0 , 6)

    print(myArray)