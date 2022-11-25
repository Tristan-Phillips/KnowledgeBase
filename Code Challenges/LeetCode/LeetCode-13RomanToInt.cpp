//To Do Work In Progress, 2016-12-12 15:00:00

#include <iostream>
#include <list>
#include <map>

using namespace std;

class Solution {
public:
    int romanToInt(string s) {
      list<char> *values = new list<char>();
      while(!s.empty()){
        char firstValue = s[0];
        values->push_back(firstValue);
        s.erase(0,1);
      }
      map<char,int> *romanMap = new map<char,int>({
        {'I',1},
        {'V',5},
        {'X',10},
        {'L',50},
        {'C',100},
        {'D',500},
        {'M',1000}
      });

      int result = 0;
      int index = 0;
      while(!values->empty()){
        char firstValue = values->front();
        values->pop_front();
        int romanFirstValue = romanMap->at(firstValue);
  
        if(index <= romanFirstValue){
          result += romanFirstValue;
        }else{
          result -= romanFirstValue;
        }
        index = romanFirstValue;
      }
      return result;
    }
};

int main(){
  Solution sol;
  int result = sol.romanToInt("MCMXCIV");
  cout << result << endl;
  return 0;
}