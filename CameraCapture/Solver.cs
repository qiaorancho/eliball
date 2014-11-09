using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CameraCapture
{
    class Solver
    {
        public DPoint getOrigin(DPoint l1, DPoint l2, DPoint r1, DPoint r2, DPoint origin, DPoint collisionPoint)
        {
            double xScale = 1;
            double yScale = 1;

            //adjust the graph
            double tmp1 = l2.x + (r1.x - l1.x);
            if (Math.Abs(tmp1 - r2.x) < 0.1)
            {
                l2.x = l2.x - 0.1;
                return getOrigin(l1, l2, r1, r2, origin, collisionPoint);
            }
            double tmp2 = r1.y + (l2.y - l1.y);
            if (Math.Abs(tmp2 - r2.y) < 0.1)
            {
                r1.y = r1.y - 0.1;
                return getOrigin(l1, l2, r1, r2, origin, collisionPoint);
            }

            // after adjustment, start get x vantage point
            DPoint xVantage = getInterSection(l1, l2, r1, r2);
            DPoint yVantage = getInterSection(l1, r1, l2, r2);

            xScale = getXFraction(l1, l2, r1, r2, origin, collisionPoint, xVantage, yVantage, 1, 0);
            yScale = getYFraction(l1, l2, r1, r2, origin, collisionPoint, xVantage, yVantage, 1, 0);

            origin.x = origin.x * xScale;
            origin.y = origin.y * yScale;
            return origin;
        }

        double getXFraction(DPoint l1, DPoint l2, DPoint r1, DPoint r2, DPoint origin, DPoint collisionPoint, DPoint xVantage, DPoint yVantage, int level, double fraction)
        {
            if (level > 3200)
            {
                return fraction;
            }

            level = level * 2;
            DPoint middle = getInterSection(l1, r2, l2, r1);
            //Console.WriteLine("midlle is : x:" + middle.x + " y:" + middle.y);

            DPoint target = getInterSection(xVantage, collisionPoint, l1, r1);


            DPoint current = getInterSection(xVantage, middle, l1, r1);


            if (Math.Abs(current.x - target.x) < 0.1)
            {
                if (current.x - target.x <= 0)
                    fraction += (1.0 / (double)level);
                return fraction;
            }

            if (current.x < target.x)
            {
                fraction += (1.0 / (double)level);
                DPoint right = getInterSection(yVantage, middle, r1, r2);
                return getXFraction(current, middle, r1, right, origin, collisionPoint, xVantage, yVantage, level, fraction);
            }
            else
            {
                DPoint left = getInterSection(l1, l2, yVantage, middle);
                return getXFraction(l1, left, current, middle, origin, collisionPoint, xVantage, yVantage, level, fraction);
            }
        }

        double getYFraction(DPoint l1, DPoint l2, DPoint r1, DPoint r2, DPoint origin, DPoint collisionPoint, DPoint xVantage, DPoint yVantage, int level, double fraction)
        {
            if (level > 3200)
            {
                return fraction;
            }

            level = level * 2;
            DPoint middle = getInterSection(l1, r2, l2, r1);
            //Console.WriteLine("midlle is : x:" + middle.x + " y:" + middle.y);

            DPoint target = getInterSection(yVantage, collisionPoint, l1, l2);
            //Console.WriteLine("targe is : x:" + target.x + " y:" + target.y);

            DPoint current = getInterSection(yVantage, middle, l1, l2);
            //Console.WriteLine("current is : x:" + current.x + " y:" + current.y);

            if (Math.Abs(current.y - target.y) < 0.1)
            {
                if (current.y - target.y <= 0)
                    fraction += (1.0 / (double)level);
                return fraction;
            }

            if (current.y < target.y)
            {
                fraction += (1.0 / (double)level);
                DPoint down = getInterSection(xVantage, middle, l2, r2);
                return getYFraction(current, l2, middle, down, origin, collisionPoint, xVantage, yVantage, level, fraction);
            }
            else
            {
                DPoint up = getInterSection(l1, r1, xVantage, middle);
                return getYFraction(l1, current, up, middle, origin, collisionPoint, xVantage, yVantage, level, fraction);
            }
        }

        DPoint getInterSection(DPoint lineA1, DPoint lineA2, DPoint lineB1, DPoint lineB2)
        {
            double xValue = 0;
            double yValue = 0;

            double A1 = lineA2.y - lineA1.y;
            double B1 = lineA1.x - lineA2.x;
            double C1 = A1 * lineA1.x + B1 * lineA1.y;

            double A2 = lineB2.y - lineB1.y;
            double B2 = lineB1.x - lineB2.x;
            double C2 = A2 * lineB1.x + B2 * lineB1.y;

            double det = A1 * B2 - A2 * B1;
            if (Math.Abs(det) < 0.001)
            {
                det = 0.001;
            }
            xValue = (B2 * C1 - B1 * C2) / det;
            yValue = (A1 * C2 - A2 * C1) / det;
            return new DPoint(xValue, yValue);
        }
    }
}
