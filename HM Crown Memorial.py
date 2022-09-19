def crown(length, height):
    for i in range(0, height):
        for j in range(0, length):
            if i == 0:
                    print(" ", end = "")    
            elif i == height - 1:
                print("-", end = "")
            elif ((j < i or j > height - i) and
                  (j < height + i or
                   j >= length - i)) :
                print ("#", end = "")
            else :
                print (" ", end = "")         
        print()
length = 51
height = int((length - 1) / 2)
crown(length, height)
print("\nRIP Queen Elizabeth II. Long Live King Charles III!\n")
