    static int jumpingOnClouds(int[] c, int k) 
    {
        int energy = 100;
        int i = 0;
        int len = c.Length;
        do
        {
            energy--;
            if(c[(i * k) % len] == 1) energy -= 2;
            i++;   
        }
        while((i * k) % len != 0);
        return energy;
    }