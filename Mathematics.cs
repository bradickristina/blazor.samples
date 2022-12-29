namespace DSS.Helpers
{
    public class Mathematics
    {
      

        public static long SumWhile(int num)
        {
            int i=num;
            int result=0;
            while(i>0){
            result +=i;
            i--;
            }
            return result;
        } 
        
        public static long SumFor(int num)
        {
            int result=0;
            for (int i= num; i>0; i-- )
            result +=i ;
            return result;
        }

        public static long SumDoWhile (int num)
        {
            int i=num;
            int result=0;
            do {
                result+=i;
                i--;
            }
            while(i>0);
        return result;
        }
        
    }
}




