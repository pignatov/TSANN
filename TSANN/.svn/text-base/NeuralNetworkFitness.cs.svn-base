using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AForge.Genetic;
using AForge.Neuro;

namespace Plig.TimeSeries.Client
{
    class NeuralNetworkFitness: IFitnessFunction
    {
        // входни данни използвани за обучение
        private double[][] mInput;
        // изходни данни използвани при обучение
        private double[][] mOutput;
        int[] mArchitecture = new int[3];
        private double sigmoidAlphaValue = 2.0;


        public NeuralNetworkFitness(double[][] inputData, double[][] outputData, int[] architecture)
        {
            this.mInput = inputData;
            this.mOutput = outputData;
            mArchitecture = architecture;
        }

        #region IFitnessFunction Members

        public double Evaluate(IChromosome chromosome)
        {
            // Конструираме невронна мрежа и изчисляваме резултата
            DoubleArrayChromosome dac = (DoubleArrayChromosome)chromosome;
            ActivationNetwork Network = new ActivationNetwork(
                     new BipolarSigmoidFunction(sigmoidAlphaValue),
                     mArchitecture[0], mArchitecture[1], mArchitecture[2]);

            int current = 0;
            int i = 0;

            // Тегла на скрит слой
            for (i = 0; i < mArchitecture[1]; i++)
            {
                for(int j=0; j < mArchitecture[0]; j++){
                    Network[0][i][j] = dac.Value[current++];
                }
            }

            // Тегла на изходен слой
            for (i = 0; i < mArchitecture[2]; i++)
            {
                for (int j = 0; j < mArchitecture[1]; j++)
                {
                    Network[1][i][j] = dac.Value[current++];
                }
            }

            double Sum = 0.0;
            for (int cnt = 0; cnt < mInput.Length; cnt++)
            {
                double[] predicted_output = Network.Compute(mInput[cnt]);
                for (int l = 0; l < predicted_output.Length; l++)
                {
                    Sum += (predicted_output[l] - mOutput[cnt][l]) * (predicted_output[l] - mOutput[cnt][l]);
                }

            }
            
            return 100-Sum;
        }

        public object Translate(IChromosome chromosome)
        {
            // Конструираме невронна мрежа и изчисляваме резултата
            DoubleArrayChromosome dac = (DoubleArrayChromosome)chromosome;
            ActivationNetwork Network = new ActivationNetwork(
                     new BipolarSigmoidFunction(sigmoidAlphaValue),
                     mArchitecture[0], mArchitecture[1], mArchitecture[2]);

            int current = 0;
            int i = 0;

            // Тегла на скрит слой
            for (i = 0; i < mArchitecture[1]; i++)
            {
                for (int j = 0; j < mArchitecture[0]; j++)
                {
                    Network[0][i][j] = dac.Value[current++];
                }
            }

            // Тегла на изходен слой
            for (i = 0; i < mArchitecture[2]; i++)
            {
                for (int j = 0; j < mArchitecture[1]; j++)
                {
                    Network[1][i][j] = dac.Value[current++];
                }
            }

            return Network;
            

        }

        #endregion
    }
}
