"""
Convert Decimal to Octal
Justin Patel
CSC120

Description: This program takes a list of decimal digits and converts them to octal digits
using a function called convertToOctal. This program works with integers only and not floating numbers 
with numbers after decimal point (example: 1.3 will not work)
"""
decimal = [1, 135, 200, 100, 8, 7]
def convertToOctal(decimalNumber):

    octalList = []   
    for i in range(len(decimal)): #iterates through each decimal value in the above list
        octal = [] #list of octal remainder values
        if decimal[i] > 7:
            remainder = decimal[i] % 8
            octal.append(remainder) #remainder of division by 8 of original decimal number and each quotient after is used to generate octal number
            quotient = int(decimal[i] / 8)
            while quotient != 0: #this will run until zero quotient is reach at which point each remainder is combined to form octal value
                remainder = quotient % 8
                quotient = int(quotient / 8)
                octal.append(remainder)
            #octal list has to be reversed because the remainder values are added one after another when octal number is reverse of this
            octal.reverse() 
            #the following is needed to convert the above list of individual digits into a single octal value
            strings = [str(integer) for integer in octal] #converts each integer value into a string
            octalString = ''.join(strings) #each string is then joined together to form one value
            octalInteger = int(octalString) #converted to integer
            octalList.append(octalInteger)
        else: #any values less than 8 will be the same in octal
            octalList.append(decimal[i])
    print(octalList)

convertToOctal(decimal)