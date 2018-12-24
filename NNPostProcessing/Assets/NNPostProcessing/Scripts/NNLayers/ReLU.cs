﻿// neural network post-processing
// https://github.com/maajor/NeuralNetworkPostProcessing

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

namespace NNPP
{
    public class ReLU : NNLayerBase
    {
        protected ComputeBuffer outputbuffer;
        public ReLU(KerasLayerConfigJson config) : base(config)
        {
            KernelId = NNCompute.Instance.Kernel("ReLU");
        }

        public override void Init(Vector3Int inputShape)
        {
            base.Init(inputShape);
            if (outputbuffer != null)
                outputbuffer.Release();
            outputbuffer = new ComputeBuffer(OutputShape.x * OutputShape.y * OutputShape.z, sizeof(float));
            Output = outputbuffer;
        }

        public override void Release()
        {
            if (outputbuffer != null)
                outputbuffer.Release();
        }

        public override void Run(object[] input, CommandBuffer cmd)
        {
            cmd.SetComputeBufferParam(NNCompute.Instance.Shader, KernelId, "LayerInput0", input[0] as ComputeBuffer);
            cmd.SetComputeBufferParam(NNCompute.Instance.Shader, KernelId, "LayerOutput", outputbuffer);
            cmd.DispatchCompute(NNCompute.Instance.Shader, KernelId, Mathf.CeilToInt(OutputShape.x * OutputShape.y * OutputShape.z / 32.0f), 1, 1);
        }
    }
}