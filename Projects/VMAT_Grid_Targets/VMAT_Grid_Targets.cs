using System;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Media.Media3D;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Media;
using VMS.TPS.Common.Model.API;
using VMS.TPS.Common.Model.Types;
using VMAT_Grid_Targets;

// TODO: Replace the following version attributes by creating AssemblyInfo.cs. You can do this in the properties of the Visual Studio project.
[assembly: AssemblyVersion("0.1.0.1")]
[assembly: AssemblyFileVersion("0.1.0.1")]
[assembly: AssemblyInformationalVersion("0.1.0.1")]

// TODO: Uncomment the following line if the script requires write access.
[assembly: ESAPIScript(IsWriteable = true)]

namespace VMS.TPS
{
    public class Script
    {
        
        public Script()
        {
        }

        public static List<Structure> spheres = new List<Structure>();

        public static int GetSlice(double z, StructureSet ss)
        {
            var imageRes = ss.Image.ZRes;
            return Convert.ToInt32((z - ss.Image.Origin.z) / imageRes);
        }

        public static IEnumerable<int> GetStructureSliceBounds(Structure structure, StructureSet ss)
        {
            var mesh = structure.MeshGeometry.Bounds;
            var meshLow = GetSlice(mesh.Z, ss);
            var meshHigh = GetSlice(mesh.Z + mesh.SizeZ, ss) + 1;
            return Enumerable.Range(meshLow, meshHigh);
        }

        public static VVector[] DrawPoint(VVector v)
        {
            VVector v1 = v;
            VVector v2 = v;
            VVector v3 = v;
            VVector v4 = v;
            VVector v5 = v;
            VVector v6 = v;
            VVector v7 = v;
            VVector v8 = v;
            VVector v9 = v;
            VVector v10 = v;
            VVector v11 = v;
            VVector v12 = v;
            VVector v13 = v;
            VVector v14 = v;
            VVector v15 = v;
            VVector v16 = v;
            VVector v17 = v;
            VVector v18 = v;

            v1.x = v.x - 2.02;
            v1.y = v.y - 0.26;
            v1.z = v.z + 0;

            v2.x = v.x - 1.85;
            v2.y = v.y + 0.74;
            v2.z = v.z + 0;

            v3.x = v.x - 1.55;
            v3.y = v.y + 0.74;
            v3.z = v.z + 0;

            v4.x = v.x - 1.55;
            v4.y = v.y + 1.07;
            v4.z = v.z + 0;

            v5.x = v.x - 0.55;
            v5.y = v.y - 1.26;
            v5.z = v.z + 0.17;

            v6.x = v.x - 0.55;
            v6.y = v.y - 1.96;
            v6.z = v.z + 0;

            v7.x = v.x - 0.55;
            v7.y = v.y - 0.26;
            v7.z = v.z + 0.3;

            v8.x = v.x - 0.55;
            v8.y = v.y + 1.74;
            v8.z = v.z + 0.05;

            v9.x = v.x + 0.45;
            v9.y = v.y + 1.97;
            v9.z = v.z + 0;

            v10.x = v.x + 0.45;
            v10.y = v.y + 1.74;
            v10.z = v.z + 0.05;

            v11.x = v.x + 0.45;
            v11.y = v.y - 1.96;
            v11.z = v.z + 0;

            v12.x = v.x + 0.45;
            v12.y = v.y + 0.74;
            v12.z = v.z - 0.27;

            v13.x = v.x + 0.78;
            v13.y = v.y + 1.74;
            v13.z = v.z + 0;

            v14.x = v.x + 1.45;
            v14.y = v.y - 1.385;
            v14.z = v.z + 0;

            v15.x = v.x + 1.45;
            v15.y = v.y + 1.24;
            v15.z = v.z + 0;

            v16.x = v.x + 1.45;
            v16.y = v.y + 0.74;
            v16.z = v.z + 0.12;

            v17.x = v.x + 1.89;
            v17.y = v.y + 0.74;
            v17.z = v.z + 0;

            v18.x = v.x + 2.01;
            v18.y = v.y - 0.26;
            v18.z = v.z + 0;

            //vectorList[0] = v1;
            //vectorList[1] = v2;
            //vectorList[2] = v3;
            //vectorList[3] = v4;
            //vectorList[4] = v5;
            //vectorList[5] = v6;
            //vectorList[6] = v7;
            //vectorList[7] = v8;
            //vectorList[8] = v9;
            //vectorList[9] = v10;
            //vectorList[10] = v11;
            //vectorList[11] = v12;
            //vectorList[12] = v13;
            //vectorList[13] = v14;
            //vectorList[14] = v15;

            VVector[] vectorList = new VVector[] { v, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18 };

            return vectorList;
        }

        public static Structure DrawSphere(VVector vector, StructureSet ss, Structure target)
        {
            StructureCodeInfo code = new StructureCodeInfo("99VMS_STRUCTCODE", "GTVp");
            Structure s = ss.AddStructure(code);
            if (target.IsHighResolution)
            {
                s.ConvertToHighResolution();
            }
            
            VVector[] point = DrawPoint(vector);
            s.AddContourOnImagePlane(point, GetSlice(vector.z, ss));
            AxisAlignedMargins margins = new AxisAlignedMargins(StructureMarginGeometry.Outer, 6.65, 6.65, 7.25, 6.65, 6.65, 7.25);
            s.SegmentVolume = s.AsymmetricMargin(margins);
            //spheres.Add(s);

            

            return s;
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        public void Execute(ScriptContext context /*, System.Windows.Window window, ScriptEnvironment environment*/)
        {
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();

            Patient patient = context.Patient;
            StructureSet ss = context.StructureSet;
            Image ct = context.Image;

            patient.BeginModifications();

            //Interface which allows user to select target
            InterfaceSelection interfaceSelection = new InterfaceSelection();
            InitialMenu initialMenu = new InitialMenu();
            initialMenu.GetStructureSet(ss);
            initialMenu.ShowDialog();
            interfaceSelection = initialMenu.Return_options;

            if (interfaceSelection.Target == null)
            {
                return;
            }

            //Set target structure to one selected by user
            Structure target = ss.Structures.Where(x => x.Id == interfaceSelection.Target).FirstOrDefault();

            //Get list of contour points in order to find min and max of x, y, and z
            List<VVector> contours = target.MeshGeometry.Positions.Select(o => new VVector(o.X, o.Y, o.Z)).ToList();

            double minX = Double.PositiveInfinity;
            double maxX = Double.NegativeInfinity;
            double minY = Double.PositiveInfinity;
            double maxY = Double.NegativeInfinity;
            double minZ = Double.PositiveInfinity;
            double maxZ = Double.NegativeInfinity;

            //Looping through each point in contour and saving min/max values
            foreach (VVector contour in contours)
            {
                if (contour.x > maxX)
                {
                    maxX = contour.x;
                }
                if (contour.x < minX)
                {
                    minX = contour.x;
                }
                if (contour.y > maxY)
                {
                    maxY = contour.y;
                }
                if (contour.y < minY)
                {
                    minY = contour.y;
                }
                if (contour.z > maxZ)
                {
                    maxZ = contour.z;
                }
                if (contour.z < minZ)
                {
                    minZ = contour.z;
                }
            }

            /*Converting the distance between min/max to steps of 15mm size. These are used in the nested loops
              below in order to step 0, 1, 2, 3... etc and be able to calculate positions of the spheres*/
            int x_size = Convert.ToInt32((maxX - minX) / 30);
            int y_size = Convert.ToInt32((maxY - minY) / 30);
            int z_size = Convert.ToInt32((maxZ - minZ) / 30);

            

            for (int z = 0; z < z_size; z++)
            {
                for (int y = 0; y < y_size; y++)
                {
                    for (int x = 0; x < x_size; x++)
                    {
                        VVector point = new VVector(minX + (x * 30), minY + (y * 30), minZ + (z * 30));
                        Structure s = DrawSphere(point, ss, target);

                        Structure overlap = ss.AddStructure("Organ", "overlap");
                        overlap.SegmentVolume = s.And(target);
                        if ((s.Volume - overlap.Volume) > 0.01)
                        {
                            ss.RemoveStructure(s);
                            //spheres.Remove(s);
                        }
                        ss.RemoveStructure(overlap);

                        if (ss.Structures.Contains(s))
                        {
                            spheres.Add(s);
                        }
                        //VVector[] g = DrawPoint(point);
                        //StructureCodeInfo code = new StructureCodeInfo("99VMS_STRUCTCODE", "GTVp");
                        //Structure s = ss.AddStructure(code);
                        //s.ConvertToHighResolution();
                        //s.AddContourOnImagePlane(g, GetSlice(point.z, ss));
                    }
                }
            }

            Structure SpheresCombined = ss.AddStructure("GTV", "SpheresTotal");
            SpheresCombined.ConvertToHighResolution();
            foreach (Structure s in spheres)
            {
                SpheresCombined.SegmentVolume = SpheresCombined.Or(s);
            }

            Structure Spheres_exp_2mm = ss.AddStructure("GTV", "Spheres2MM");
            Structure Spheres_exp_7mm = ss.AddStructure("GTV", "Spheres7MM");
            Spheres_exp_2mm.ConvertToHighResolution();
            Spheres_exp_7mm.ConvertToHighResolution();
            Spheres_exp_2mm.SegmentVolume = SpheresCombined.Margin(2);
            AxisAlignedMargins ringMargin = new AxisAlignedMargins(StructureMarginGeometry.Outer, 6, 6, 5, 6, 6, 5);
            Spheres_exp_7mm.SegmentVolume = SpheresCombined.AsymmetricMargin(ringMargin);

            Structure ringOuter = ss.AddStructure("CONTROL", "RingOuter");
            Structure ringInner = ss.AddStructure("CONTROL", "RingInner");

            ringOuter.SegmentVolume = target.Sub(Spheres_exp_7mm);
            ringInner.SegmentVolume = target.Sub(Spheres_exp_2mm);
            ringInner.SegmentVolume = ringInner.Sub(ringOuter);

            ringOuter.Color = Color.FromRgb(185, 82, 62);
            ringInner.Color = Color.FromRgb(0, 0, 128);

            ss.RemoveStructure(Spheres_exp_2mm);
            ss.RemoveStructure(Spheres_exp_7mm);
            ss.RemoveStructure(SpheresCombined);

            watch.Stop();
            TimeSpan time = watch.Elapsed;
            string elapsed_time = $"{time.Hours:00}:{time.Minutes:00}:{time.Seconds:00}.{time.Milliseconds:00}";
            MessageBox.Show(elapsed_time);
        }
  } 
}
