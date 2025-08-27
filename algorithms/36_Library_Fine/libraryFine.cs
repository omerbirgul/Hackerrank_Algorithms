public static int libraryFine(int d1, int m1, int y1, int d2, int m2, int y2)
    {

        
        int fineAmount = 0;
        
        if(y1 > y2)
        {
            fineAmount = 10000;
        }
        
        else if(y1 == y2)
        {
            if(m1 > m2){
                fineAmount = (m1 - m2) * 500;
            }
            else if(m1 == m2){
                if(d1 > d2){
                    fineAmount = (d1 - d2) * 15;
                }
            }
        }
        
        return fineAmount > 0 ? fineAmount : 0;
    }