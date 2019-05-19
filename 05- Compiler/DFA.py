
class DFA:
    
    def __init__(self):
             #pass
             self.DfaTable = []
                           
    def GFATable(self):
        
        self.no_of_state = int(input("Enter Number of State:"))+1
        self.no_of_terminals = int(input("Enter Number of Terminal:"))+1
        self.DfaTable = [x[:] for x in [[0]*self.no_of_terminals]*self.no_of_state]
        
        
        print("Enter the element of Table: ")
        for i in range(self.no_of_state):
            for j in range(self.no_of_terminals):
    
                if i == 0 and j == 0:
                    self.DfaTable[i][j] = ' '
                    continue
                self.DfaTable[i][j] = input().strip()
        
        
        self.final_state = input("Enter Final State: ")
        
            
    def initialState(self):
        return self.DfaTable[1][0];
        
    def nextState(self, currentState, currentChar):
        for i in range(self.no_of_state):
            if currentState == self.DfaTable[i][0]:
                for j in range(self.no_of_terminals):
                    if currentChar == self.DfaTable[0][j]:
                        return self.DfaTable[i][j]
        return '$'
    
    def nextChar(self):
        if len(self.List_input) == 0 or self.List_input_count == len(self.List_input):
            return '$'
        else:
            char = self.List_input[self.List_input_count]
            self.List_input_count += 1
            return char

    
    def is_FinalState(self, currentState):
        
        if str(currentState) == str(self.final_state):
            print("Statisfy :) ")
        else:
            print("Not Statisfy :( ")
    
    def Move(self, currentState, currentChar):
        return self.nextState(currentState, currentChar)
    
    
    
    def DFA_Algorithm(self):
        self.currentState = self.initialState()
        self.currentChar = self.nextChar()

        while self.currentChar != '$':
            self.currentState = self.Move(self.currentState, self.currentChar)
            self.currentChar = self.nextChar()
            
        self.is_FinalState(self.currentState)
            
            
        
    def excute(self):
        
        while 1:
            self.List_input = list(input("Enter Input String (e to exit): "))
            if self.List_input[0] == 'e' or self.List_input[0] == 'E':
                break
            self.List_input_count = 0
            self.DFA_Algorithm()
    
if __name__ == '__main__':
    
    obj = DFA()
    obj.GFATable()
    obj.excute()


    