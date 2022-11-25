/*Provides the following error in leetCode and I have no Idea why

Line 11: Char 39: runtime error: signed integer overflow: 998765432 * 10 cannot be represented in type 'int' (solution.cpp)
SUMMARY: UndefinedBehaviorSanitizer: undefined-behavior prog_joined.cpp:20:39

*/

#include <iostream>

using namespace std;

class Solution {
public:
    bool isPalindrome(int x) {
      int keepValue = x;
      if(x < 0 || ((x % 10 == 10))){
        return false;
      }
      int reverseNumber(0);
      while(x > 0){
        reverseNumber = reverseNumber * 10 + x % 10;
        x = x / 10;
      }
      return keepValue == reverseNumber ? true : false;
    }
};  

int main(){
  Solution sol;
  cout << sol.isPalindrome(151);
  return 0;
}