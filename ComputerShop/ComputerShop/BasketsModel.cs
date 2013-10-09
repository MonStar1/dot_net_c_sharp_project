using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerShop
{
    class BasketsModel
    {
    private long id;

    public long Id
        {
            get { return id; }
            set { id = value; }
        }
    
    private long time;

    public long Time
        {
            get { return time; }
            set { time = value; }
        }

    private ENUM status;

    public ENUM Status
        {
            get { return status; }
            set { status = value; }
        }

    private double total_price;

    public double Total_price
        {
            get { return total_price; }
            set { total_price = value; }
        }
    }
}
