using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_4_Jean_Oliveira
{
    class DeskOrder
    {
        //The DeskOrder class contains the logic behind a quote for a new desk order based upon size,
        // of drawers, desktop material(Desk Class), and if the desk has been placed on rush order.

        private int doWidth;
        private int doDepth;
        private int doSurfaceArea;
        private int doDrawers;
        private string doMaterial;
        private int doRushDays;

        public int deskQuote { get; set; }
        public DateTime quoteDate { get; set; }

        public int BASEPRICE = 200; //The base price for any desk quote
        private int BASESIZE = 1000; // tHE BASE PRICE FOR SIZE MAXIMUM
        private int DRAWERCOST = 50; //cost per drawer
        private int SURFACECOST = 1; //cost per square inch greater than BASESIZE per desk
        private int RUSH1 = 3; private int RUSH2 = 5; private int RUSH3 = 7; // Rush order days options

        public DeskOrder (int width, int depth, int drawers, string material, int rushDays)
        {
            doWidth = width;
            doDepth = depth;
            doSurfaceArea = width * depth;
            doDrawers = drawers;
            doMaterial = material;
            doRushDays = rushDays;
        }

        public int surfaceCost()
        {
            //Determine if additional cost is warranted with desk areas greater than DESKTOP BASE SIZE

            if (doSurfaceArea > BASESIZE)
            {
                return (doSurfaceArea - BASESIZE) * SURFACECOST;
            }
            else
            {
                return 0;
            }
        }

        public int drawerCost()
        {
            return doDrawers * DRAWERCOST;
        }

        public int SurfaceMaterialCost()
        {
            //Select the material cost
            int materialCost = 0;
            switch (doMaterial)
            {
                case "laminate":
                    materialCost = 100;
                    break;
                case "oak":
                    materialCost = 200;
                    break;
                case "pine":
                    materialCost = 50;
                    break;
                default:
                    materialCost = -1;//error check
                    break;
            }
            return materialCost;
        }

        public int RushOrderCost()
        {
            //magic number used for surface area and costs
            int rushCost = 0;
            if (doRushDays <= RUSH1)
            {
                if (doSurfaceArea <= BASESIZE)
                {
                    rushCost = 60;
                }
                else if (doSurfaceArea <= 1999)
                {
                    rushCost = 70;
                }
                else
                {
                    rushCost = 80;
                }
            }
            if (doRushDays <= RUSH2)
            {
                if (doSurfaceArea <= BASESIZE)
                {
                    rushCost = 40;
                }
                else if (doSurfaceArea <= 1999)
                {
                    rushCost = 50;
                }
                else
                {
                    rushCost = 60;
                }
            }
            if (doRushDays <= RUSH3)
            {
                if (doSurfaceArea <= BASESIZE)
                {
                    rushCost = 30;
                }
                else if (doSurfaceArea <= 1999)
                {
                    rushCost = 35;
                }
                else
                {
                    rushCost = 40;
                }
            }
            return rushCost;
        }
    }
}
