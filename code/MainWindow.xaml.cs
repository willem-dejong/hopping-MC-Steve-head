//Willem DeJong
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Media.Media3D;
using System.Windows.Media.Animation;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double S = Math.Sqrt(2 * Math.Pow(40.0, 2));
        double x = -40, y = 40, z = 0;
        double theta = 3 * Math.PI / 4;
        double phi = Math.PI / 2;
        double thetaD = .1;
        private static bool jumping = false;
        //GeometryModel3D r2 = new GeometryModel3D();
        //GeometryModel3D r3 = new GeometryModel3D();
        //GeometryModel3D r4 = new GeometryModel3D();
        //GeometryModel3D r5 = new GeometryModel3D();
        //GeometryModel3D r6 = new GeometryModel3D();
        //MeshGeometry3D rr = new MeshGeometry3D();
        //MeshGeometry3D rr2 = new MeshGeometry3D();
        //MeshGeometry3D rr3 = new MeshGeometry3D();
        //MeshGeometry3D rr4 = new MeshGeometry3D();
        //MeshGeometry3D rr5 = new MeshGeometry3D();
        //MeshGeometry3D rr6 = new MeshGeometry3D();
        //double a = 4;
        public MainWindow()
        {
            InitializeComponent();
            this.Show();
            PerspectiveCamera p = new PerspectiveCamera();
            Point3D pp = new Point3D(x, y, z);
            Vector3D ppp = new Vector3D(-x, -y, 0);
            Vector3D pppp = new Vector3D(0, 0, 1);
            p.UpDirection = pppp;
            p.Position = pp;
            p.LookDirection = ppp;
            gg.Camera = p;
            Vector3D qqqq = new Vector3D(1, 0, 0);
            DirectionalLight qqq = new DirectionalLight(Colors.White, qqqq);
            Vector3D qqqq2 = new Vector3D(0, -1, 0);
            DirectionalLight qqq2 = new DirectionalLight(Colors.White, qqqq2);
            Vector3D qqqq3 = new Vector3D(0, 0, -1);
            DirectionalLight qqq3 = new DirectionalLight(Colors.White, qqqq3);
            Vector3D qqqq4 = new Vector3D(0, 0, 1);
            DirectionalLight qqq4 = new DirectionalLight(Colors.White, qqqq4);
            Vector3D qqqq5 = new Vector3D(0, 1, 0);
            DirectionalLight qqq5 = new DirectionalLight(Colors.White, qqqq5);
            Vector3D qqqq6 = new Vector3D(-1, 0, 0);
            DirectionalLight qqq6 = new DirectionalLight(Colors.White, qqqq6);
            ggg.Children.Add(qqq);//0
            ggg.Children.Add(qqq2);//1
            ggg.Children.Add(qqq3);//2
            ggg.Children.Add(qqq4);//3
            ggg.Children.Add(qqq5);//4
            ggg.Children.Add(qqq6);//5
            //rr.Positions.Add(new Point3D(-a, -a, -a));//0
            //rr.Positions.Add(new Point3D(a, -a, -a));//1
            //rr.Positions.Add(new Point3D(a, a, -a));//2
            //rr.Positions.Add(new Point3D(-a, a, -a));//3
            //rr2.Positions.Add(new Point3D(-a, -a, -a));//0
            //rr2.Positions.Add(new Point3D(-a, -a, a));//1
            //rr2.Positions.Add(new Point3D(-a, a, a));//2
            //rr2.Positions.Add(new Point3D(-a, a, -a));//3
            //rr3.Positions.Add(new Point3D(-a, a, -a));//0
            //rr3.Positions.Add(new Point3D(-a, a, a));//1
            //rr3.Positions.Add(new Point3D(a, a, a));//2
            //rr3.Positions.Add(new Point3D(a, a, -a));//3
            //rr4.Positions.Add(new Point3D(-a, -a, a));
            //rr4.Positions.Add(new Point3D(a, -a, a));
            //rr4.Positions.Add(new Point3D(a, a, a));
            //rr4.Positions.Add(new Point3D(-a, a, a));
            //rr5.Positions.Add(new Point3D(-a, -a, -a));
            //rr5.Positions.Add(new Point3D(a, -a, -a));
            //rr5.Positions.Add(new Point3D(a, -a, a));
            //rr5.Positions.Add(new Point3D(-a, -a, a));
            //rr6.Positions.Add(new Point3D(a, -a, -4));
            //rr6.Positions.Add(new Point3D(a, a, -a));
            //rr6.Positions.Add(new Point3D(a, a, a));
            //rr6.Positions.Add(new Point3D(a, -a, a));
            //rr.TriangleIndices.Add(0);
            //rr.TriangleIndices.Add(1);
            //rr.TriangleIndices.Add(3);
            //rr.TriangleIndices.Add(1);
            //rr.TriangleIndices.Add(2);
            //rr.TriangleIndices.Add(3);
            //rr2.TriangleIndices.Add(0);
            //rr2.TriangleIndices.Add(1);
            //rr2.TriangleIndices.Add(3);
            //rr2.TriangleIndices.Add(1);
            //rr2.TriangleIndices.Add(2);
            //rr2.TriangleIndices.Add(3);
            //rr3.TriangleIndices.Add(0);
            //rr3.TriangleIndices.Add(1);
            //rr3.TriangleIndices.Add(3);
            //rr3.TriangleIndices.Add(1);
            //rr3.TriangleIndices.Add(2);
            //rr3.TriangleIndices.Add(3);
            //rr4.TriangleIndices.Add(0);
            //rr4.TriangleIndices.Add(1);
            //rr4.TriangleIndices.Add(3);
            //rr4.TriangleIndices.Add(1);
            //rr4.TriangleIndices.Add(2);
            //rr4.TriangleIndices.Add(3);
            //rr5.TriangleIndices.Add(0);
            //rr5.TriangleIndices.Add(1);
            //rr5.TriangleIndices.Add(3);
            //rr5.TriangleIndices.Add(1);
            //rr5.TriangleIndices.Add(2);
            //rr5.TriangleIndices.Add(3);
            //rr6.TriangleIndices.Add(0);
            //rr6.TriangleIndices.Add(1);
            //rr6.TriangleIndices.Add(3);
            //rr6.TriangleIndices.Add(1);
            //rr6.TriangleIndices.Add(2);
            //rr6.TriangleIndices.Add(3);
            //rr.TextureCoordinates.Add(new Point(0, 0));
            //rr.TextureCoordinates.Add(new Point(0, 8));
            //rr.TextureCoordinates.Add(new Point(8, 8));
            //rr.TextureCoordinates.Add(new Point(8, 0));
            //rr2.TextureCoordinates.Add(new Point(8, 8));
            //rr2.TextureCoordinates.Add(new Point(8, 0));
            //rr2.TextureCoordinates.Add(new Point(0, 0));
            //rr2.TextureCoordinates.Add(new Point(0, 8));
            //rr3.TextureCoordinates.Add(new Point(8, 8));
            //rr3.TextureCoordinates.Add(new Point(8, 0));
            //rr3.TextureCoordinates.Add(new Point(0, 0));
            //rr3.TextureCoordinates.Add(new Point(0, 8));
            //rr4.TextureCoordinates.Add(new Point(0, 0));
            //rr4.TextureCoordinates.Add(new Point(0, 8));
            //rr4.TextureCoordinates.Add(new Point(8, 8));
            //rr4.TextureCoordinates.Add(new Point(8, 0));
            //rr5.TextureCoordinates.Add(new Point(0, 8));
            //rr5.TextureCoordinates.Add(new Point(8, 8));
            //rr5.TextureCoordinates.Add(new Point(8, 0));
            //rr5.TextureCoordinates.Add(new Point(0, 0));
            //rr6.TextureCoordinates.Add(new Point(0, 8));
            //rr6.TextureCoordinates.Add(new Point(8, 8));
            //rr6.TextureCoordinates.Add(new Point(8, 0));
            //rr6.TextureCoordinates.Add(new Point(0, 0));
            //r.Geometry = rr;
            //r2.Geometry = rr2;
            //r3.Geometry = rr3;
            //r4.Geometry = rr4;
            //r5.Geometry = rr5;
            //r6.Geometry = rr6;
            //ImageBrush b2 = new ImageBrush(new BitmapImage(new Uri("C:/Users/willem/Desktop/headright.png")));
            //ImageBrush b3 = new ImageBrush(new BitmapImage(new Uri("C:/Users/willem/Desktop/headfront.png")));
            //ImageBrush b4 = new ImageBrush(new BitmapImage(new Uri("C:/Users/willem/Desktop/headtop.png")));
           // ImageBrush b5 = new ImageBrush(new BitmapImage(new Uri("C:/Users/willem/Desktop/headback.png")));
            //ImageBrush b6 = new ImageBrush(new BitmapImage(new Uri("C:/Users/willem/Desktop/headleft.png")));
            //brush =new ImageBrush(new BitmapImage(new Uri("C:/Users/willem/Desktop/headunder.png")));
            //brush = new DiffuseMaterial(b);
            //r2.Material = new DiffuseMaterial(b2);
            //r2.BackMaterial = new DiffuseMaterial(b2);
            //r3.Material = new DiffuseMaterial(b3);
            //r3.BackMaterial = new DiffuseMaterial(b3);
            //r4.Material = new DiffuseMaterial(b4);
            //r4.BackMaterial = new DiffuseMaterial(b4);
            //r5.Material = new DiffuseMaterial(b5);
            //r5.BackMaterial = new DiffuseMaterial(b5);
            //r6.Material = new DiffuseMaterial(b6);
            //r6.BackMaterial = new DiffuseMaterial(b6);
            //ggg.Children.Add(r);//6
            //ggg.Children.Add(r2);//7
            //ggg.Children.Add(r3);//8
            //ggg.Children.Add(r4);//9
            //ggg.Children.Add(r5);//10
            //ggg.Children.Add(r6);//11
            //g.Content = ggg;
            //gg.Children.Add(g);
            this.Show();
        }
        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.Key)
            {
                //case Key.Up:
                //case Key.Down:
                case Key.Left:
                    theta = theta - thetaD;
                    x = S * Math.Cos(theta) * Math.Sin(phi);
                    y = S * Math.Sin(theta) * Math.Sin(phi);
                    PerspectiveCamera p = new PerspectiveCamera();
                    p.Position = new Point3D(x, y, z);
                    p.LookDirection = new Vector3D(-x, -y, -z);
                    p.UpDirection = new Vector3D(0, 0, 1);
                    gg.Camera = p;
                    break;
                case Key.Right:
                    theta = theta + thetaD;
                    x = S * Math.Cos(theta) * Math.Sin(phi);
                    y = S * Math.Sin(theta) * Math.Sin(phi);
                    p = new PerspectiveCamera();
                    p.Position = new Point3D(x, y, z);
                    p.LookDirection = new Vector3D(-x, -y, -z);
                    p.UpDirection = new Vector3D(0, 0, 1);
                    gg.Camera = p;
                    break;
                case Key.Up:
                    phi = phi - thetaD;
                    if (phi <= 0)
                        phi = .1;
                    z = S * Math.Cos(phi);
                    x = S * Math.Cos(theta) * Math.Sin(phi);
                    y = S * Math.Sin(theta) * Math.Sin(phi);
                    p = new PerspectiveCamera();
                    p.Position = new Point3D(x, y, z);
                    p.LookDirection = new Vector3D(-x, -y, -z);
                    p.UpDirection = new Vector3D(0, 0, 1);
                    gg.Camera = p;
                    break;
                case Key.Down:
                    phi = phi + thetaD;
                    if (phi >= Math.PI)
                        phi = Math.PI - .1;
                    phi = phi + thetaD;
                    z = S * Math.Cos(phi);
                    x = S * Math.Cos(theta) * Math.Sin(phi);
                    y = S * Math.Sin(theta) * Math.Sin(phi);
                    p = new PerspectiveCamera();
                    p.Position = new Point3D(x, y, z);
                    p.LookDirection = new Vector3D(-x, -y, -z);
                    p.UpDirection = new Vector3D(0, 0, 1);
                    gg.Camera = p;
                    break;
                case Key.Space:
                    if (!jumping)
                    {
                        jumping = true;
                        stowy.Storyboard.Begin();
                        story.Storyboard.Begin();
                    }
                    break;
                
            }
        }

        private void Storyboard_Completed(object sender, EventArgs e)
        {
            jumping = false;
        }
    }
    public partial class CustomGravityEasingFunction : EasingFunctionBase
    {
        public CustomGravityEasingFunction()
            : base()
        {
        }

        // Specify your own logic for the easing function by overriding
        // the EaseInCore method. Note that this logic applies to the "EaseIn"
        // mode of interpolation. 
        protected override double EaseInCore(double normalizedTime)
        {
            // applies the formula of time to the seventh power.
            double temp =5 * normalizedTime - 9.81 * 0.5 * Math.Pow(normalizedTime, 2);
            //if (temp < -4)
                //temp = -4;

            return temp;
        }

        // Typical implementation of CreateInstanceCore
        protected override Freezable CreateInstanceCore()
        {
            return new CustomGravityEasingFunction();
        }
    }
}
