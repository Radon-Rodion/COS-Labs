using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace СhanceApproach
{
    internal class PointsByTask
    {
        int _nPoints;

        const double AMPLITUDE_1 = 7;
        const double FREQUENCY_1 = 5;
        readonly double[] PHASES_1 = { Math.PI, 0, Math.PI/3, Math.PI/6, Math.PI/2};

        const double AMPLITUDE_2 = 5;
        const double PHASE_2 = 3 *Math.PI / 4;
        readonly double[] FREQUENCIES_2 = { 1, 5, 11, 6, 3 };

        const double FREQUENCY_3 = 3;
        const double PHASE_3 = 3*Math.PI / 4;
        readonly double[] AMPLITUDES_3 = { 1, 2, 11, 4, 2 };

        readonly (double amplitude, double frequency, double phase)[] POLYHARMONIC_PARAMS = { 
            (9, 1, Math.PI/2), 
            (9, 2, 0),
            (9, 3, Math.PI/4),
            (9, 4, Math.PI/3),
            (9, 5, Math.PI/6),
        };

        readonly TextBox[] _phaseValues;

        const double PARAMS_GROWTH = 0.3;

        public PointsByTask(int nPoints, TextBox[] phaseValues = null)
        {
            _nPoints = nPoints;
            _phaseValues = phaseValues;
        }

        public double[][] this[int task]
        {
            get
            {
                if (task != 5 && _phaseValues != null)
                    for (var i = 0; i < _phaseValues.Length; i++)
                        _phaseValues[i].Text = POLYHARMONIC_PARAMS[i].phase.ToString();

                switch (task)
                {
                    case 0:
                        {
                            double[][] res = new double[PHASES_1.Length][];
                            for (int i = 0; i < PHASES_1.Length; i++)
                            {
                                res[i] = (new HarmonicSignalGenerator(AMPLITUDE_1, FREQUENCY_1, PHASES_1[i])).GenerateSignalPoints(_nPoints);
                            }
                            return res;
                        }
                    case 1:
                        {
                            double[][] res = new double[FREQUENCIES_2.Length][];
                            for (int i = 0; i < FREQUENCIES_2.Length; i++)
                            {
                                res[i] = (new HarmonicSignalGenerator(AMPLITUDE_2, FREQUENCIES_2[i], PHASE_2)).GenerateSignalPoints(_nPoints);
                            }
                            return res;
                        }
                    case 2:
                        {
                            double[][] res = new double[AMPLITUDES_3.Length][];
                            for (int i = 0; i < AMPLITUDES_3.Length; i++)
                            {
                                res[i] = (new HarmonicSignalGenerator(AMPLITUDES_3[i], FREQUENCY_3, PHASE_3)).GenerateSignalPoints(_nPoints);
                            }
                            return res;
                        }
                    case 3:
                        {
                            double[][] res = new double[1][];
                            res[0] = (new PolyharmonicSignalGenerator(POLYHARMONIC_PARAMS)).GenerateSignalPoints(_nPoints);
                            return res;
                        }
                    case 4:
                        {
                            (double amplitude, double frequency, double phase)[] polyharmonicParams =  { (1, 4, 1), (0.5, 8, 0.5), (0.25, 16, 0) };
                            double[][] res = new double[1][];
                            res[0] = (new PolyharmonicLinearyGrowingSignalGenerator(polyharmonicParams, 1+PARAMS_GROWTH/_nPoints)).GenerateSignalPoints(_nPoints);
                            return res;
                        }
                    case 5:
                        {
                            var polyharmonicSignalParams = new (double amplitude, double frequency, double phase)[POLYHARMONIC_PARAMS.Length];
                            Array.Copy(POLYHARMONIC_PARAMS, polyharmonicSignalParams, POLYHARMONIC_PARAMS.Length);
                            for(var i=0; i<_phaseValues.Length; i++)
                            {
                                polyharmonicSignalParams[i].phase = System.Convert.ToDouble(_phaseValues[i].Text);
                            }
                            double[][] res = new double[1][];
                            res[0] = (new PolyharmonicSignalGenerator(polyharmonicSignalParams)).GenerateSignalPoints(_nPoints);
                            return res;
                        }
                    default:
                        return null;
                }
            }
        }
    }
}
