namespace Stack
{
    class Stack
    {
        private int[] arr;
        private int pos1 = 0;
        private int pos2 = 0;
        public Stack(int length)
        {
            arr = new int[length];
            pos2 = length - 1;
        }

        public void Push1(int data)
        {
            if (pos2 - pos1 > 2)
            {
                arr[pos1] = data;
                pos1++;
            }
        }

        public void Push2(int data)
        {
            arr[pos2] = data;
            pos1--;
        }

    }
}





