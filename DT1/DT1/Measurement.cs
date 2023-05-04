using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DT1
{
    [Serializable()]
    public class Measurement
    {
        public bool _MeasuringStatus1 { get; set; }
        public bool _MeasuringStatus2 { get; set; }

        public string _NumPart { get; set; }
        public double[] _WCS { get; set; }
        public int _NumInspection { get; set; }
        public string[] _InspectionID { get; set; }
        public int[] _NumPoint { get; set; }

        public double[] _DesignPos { get; set; }
        public double[] _MeasuredPos { get; set; }
        public double[] _InspectionResult { get; set; }
        public double[] _InspectionTolerance { get; set; }
        //public double[] _EstimatedTool { get; set; }

        public Measurement(string numPart, double[] wcs, int numInspection, string[] inspectionID, int[] numPoint, double[] des, double[] mes, double[] inspectionResult, double[] inspectionTolerance)
        {
            _NumPart = numPart;
            _WCS = wcs;
            _NumInspection = numInspection;
            _InspectionID = inspectionID;
            _NumPoint = numPoint;
            _DesignPos = des;
            _MeasuredPos = mes;
            _InspectionResult = inspectionResult;
            _InspectionTolerance = inspectionTolerance;
        }
    }

}
