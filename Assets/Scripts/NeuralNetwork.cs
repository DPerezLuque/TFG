﻿//using Keras.Models;
using System.IO;
using UnityEngine;
using Unity.Barracuda;


public class NeuralNetwork
{
    public NNModel model;
    private Model m_RuntimeModel;
    private IWorker worker;

    void Start()
    {
        m_RuntimeModel = ModelLoader.Load(model);
        worker = WorkerFactory.CreateWorker(WorkerFactory.Type.Auto, m_RuntimeModel);
    }

    public int Movement(float [,] Xnew)
    {
        int move = -1;

        //Carga el modelo ya entrenado
        //string model_path = Application.dataPath + @"\Red_Neuronal\Modelo\model.json";
        //string weights_path = Application.dataPath + @"\Red_Neuronal\Modelo\model.h5";

        //var model = Sequential.ModelFromJson(File.ReadAllText(model_path));
        //model.LoadWeight(weights_path);

        //Predice el tipo de un movimiento dado y devuelve el valor
        //var ynew = model.Predict(Xnew);

        //move = (int)ynew[0];
        

        return move;
    }

        
}


