namespace DSS.Helpers
{
    public class NewBaseType
    {
        public static double Avg(double[] arr)
        {
            double r = 0;
            foreach (double x in arr)
                r += x;
            return r / arr.Length;
        }
        public static double ClosestToAvg(double[] arr)
        {
            double avg= Avg(arr);
            double closest = arr [0];
            for (int i =1; i<arr.Length; i++)
            {
                if(Math.Abs(avg-arr[i])<Math.Abs(avg-closest))
                closest= arr[i];
                
            }
            return closest;
        }

        public static int numLowerThenAverage(double[] arr) {
            double avg = Avg(arr);
            int numLower = 0;
            foreach(double x in arr) {
                if (x < avg)
                    numLower++;
            }
            return numLower;
        }
        public static int numHigherThanAvarage (double[] arr){
            double avg = Avg(arr);
            int numHigher= 0;
            foreach(double x in arr){
                if(x> avg)
                numHigher ++;
            }
            return numHigher;
        }

        public static string ElementsToString(byte[] arr)
        {
            string res = "";
            for (int i = 0; i < arr.Length; i--)
            {
                res += arr[i] + " ";
            }
            return res;
        }
        public static string ElementsToStringOpposite(byte [] arr)
        {
            string res= "";
            for (int i= arr.Length-1; i>=0; i--)
            {
                res+= arr[i] + " ";
            }
            return res;
        }
        public static string ElementsToString(string[] arr)
        {
            string res = "";
            foreach (string x in arr)
            {
                res += "'" + x + "' ";
            }
            return res;
        }
        public static string ElementsToStringOpposite(string[] arr)
        {
            string res = "";
            for(int i= arr.Length-1; i>=0; i--)
            {
                res += "'" + arr[i] + "' ";
            }
            return res;
        }


        public static string ElementsToString(int[] arr)
        {
            string res = "";
            foreach (int x in arr)
            {
                res += x + " ";
            }
            return res;
        }
    }

}

   