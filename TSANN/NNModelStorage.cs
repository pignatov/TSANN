using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AForge.Neuro;

namespace Plig.TimeSeries.Client
{
    [Serializable]
    class NNModelStorage: IModelStorage
    {
        private int[] mDepVariables;
        private int[] mIndepVariables;
        private int mEpochs;
        private int mReinitializations;
        private ActivationNetwork mBestNetwork;
        private ActivationNetwork mBestTestNetwork;
        private ActivationNetwork mSelectedNetwork;
        private bool mFixedNumberOfNeurons;
        private bool mFlexibleNumberOfNeurons;
        private int mTestSamples;


        public int[] DepVariables
        {
            get { return mDepVariables; }
            set { mDepVariables = value; }
        }

        public int[] IndepVariables
        {
            get { return mIndepVariables; }
            set { mIndepVariables = value; }
        }

        public int Epochs
        {
            get { return mEpochs; }
            set { mEpochs = value; }
        }

        public int Reinitializations
        {
            get { return mReinitializations; }
            set { mReinitializations = value; }
        }

        public ActivationNetwork BestNetwork
        {
            get { return mBestNetwork;}
            set { mBestNetwork = value;}
        }

        public ActivationNetwork BestTestNetwork
        {
            get { return mBestTestNetwork; }
            set { mBestTestNetwork = value; }
        }

        public ActivationNetwork SelectedNetwork
        {
            get { return mSelectedNetwork; }
            set { mSelectedNetwork = value; }
        }
        
        public bool FixedNumberOfNeurons
        {
            get { return mFixedNumberOfNeurons; }
            set { mFixedNumberOfNeurons = value; }
        }

        public bool FlexibleNumberOfNeurons
        {
            get { return mFlexibleNumberOfNeurons; }
            set { mFlexibleNumberOfNeurons = value; }
        }

        public int TestSamples
        {
            get { return mTestSamples; }
            set { mTestSamples = value; }
        }
        

    }
}
