class Solution:
    def isValid(self, s: str) -> bool:
        cl = set(['(', '{' , '['])
        mp = {
            ']':'[',
        ')':'(', 
        '}':'{'
        }
        st = []
        for i in s:
            if i in cl:
                st.append(i)
            elif i in mp:
                if len(st)!=0 and (st[-1] == mp[i]):
                   
                    st.pop()
                else:
                    return False
        return len(st)==0

        