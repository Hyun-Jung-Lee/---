using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alg5Permute
{
    class Solution
    {
        private List<String> result;

        //n is the pairs will attend
        public List<String> Permute(int n)
        {
            result = new List<String>();
            DFS(n, 1, 0, "F");//Start with first one is female
            DFS(n, 0, 1, "M");//Start with first one is male
            return result;
        }

        //DFS recursive arrange female, male
        private void DFS(int n, int fc, int mc, String solution)
        {
            //if fc==n meaning all female has arranged 
            if (fc == n && mc == n)
            {
                result.Add(solution);
                return;
            }

            if (fc < n) DFS(n, fc + 1, mc, solution + "F");//if fc less than n, add one more female to arrange
            if (mc < n) DFS(n, fc, mc + 1, solution + "M");//if mc less than n, add one more male to arrange
        }

        /*-----------------------------------------------------------*/
        //Add one more condition, "Lady first", meaning F always >= M. 
        // Replace F with "(", M with ")", it will be Pair Parentheses Problem
        public List<String> Parentheses(int n)
        {
            result = new List<String>();
            DFSParenth(n, 1, 0, "(");//Start with first one is female            
            return result;
        }

        //DFS recursive arrange female, male
        private void DFSParenth(int n, int fc, int mc, String solution)
        {
            //if fc==n meaning all female has arranged 
            if (fc == n && mc == n)
            {
                result.Add(solution);
                return;
            }

            if (fc < n) DFSParenth(n, fc + 1, mc, solution + "(");//if fc less than n, add one more female to arrange
            if (mc < fc) DFSParenth(n, fc, mc + 1, solution + ")");//mc always <= fc
        }
        
        
        /*-----------------------------------------------------------*/
        //Another way, generate all parenthese first, then valid the corret pairs.
        //whenever, "(" > "(", remove this soluion.
        public List<String> Valid(List<String> originalResult)
        {
            List<String> copyResult = new List<String>();//Create a list to deep copy origianlResult
            foreach(var i in originalResult)
            {
                copyResult.Add(i);
            }

            var balance = 0;
            Boolean rm;
            List<String> rmList = new List<String>();// Create a list to record removed data location                       

            foreach (var i in copyResult)
            {
                rm = false;
                foreach (char c in i)
                {
                    if (c == 'F') balance++;
                    if (c == 'M') balance--;
                    if (balance < 0) rm = true;
                }
                if (rm)
                {
                    //Console.WriteLine("Need to remove!");
                    rmList.Add(i);
                }
            }  
            foreach(var m in rmList)
            {
                copyResult.Remove(m);
            }
            return copyResult;
        }

    }
}
