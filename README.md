# QuantumAssignment
combinatorial optimisation task

### Resources Used

>  [quantum-approximate-optimization-algorithm](https://docs.microsoft.com/en-us/samples/microsoft/quantum/quantum-approximate-optimization-algorithm/)


>  [qaoa/QAOA.qs](https://github.com/microsoft/Quantum/blob/main/samples/simulation/qaoa/QAOA.qs)


>  [hybrid-quantum-applications](https://devblogs.microsoft.com/qsharp/hybrid-quantum-applications-with-azure-functions/)


>  [quickstart-microsoft-qc](https://docs.microsoft.com/en-us/azure/quantum/quickstart-microsoft-qc?pivots=platform-ionq)

### Steps to run the application
* Clone the application
* Open QAOA.sln in Visual Studio 2022 (Quantum SDK supported in .net6, .net6 is supported in Visual Studio 2022)
* Run the App
* Open postman with post req as "http://localhost:7071/api/Function1" and add payload in the body

```
{
    "request_id": "507f1f77bcf86cd799439011",
      "user_id": "test_user1",
      "feature_type": "QUBO solve",
      "input": {
          "pipeline":{
              "algorithm" : "QAOA",
              "depth" : 2,
              "optimizer" : "Powell",
              "shots" : 10
          },
          "device": "ionq",
          "qubo": {
              "num_variables": 4,
              "edges" : "[(0,1), (0,2), (1,1), (3,3)]",
              "weights" : "[1,1,-1,1]"
          }
       }
}
```
* Response received is in the format

```
output = {
	 "status" : “SUCCESS”,
       "optimal_solution" : [1, -1, 1, 1],
       "optimal_energy" : -4.25,
       "optimal_parameters" : [[0.5, -2], [0.34, -0.8]],
}
```
### Function App Aure Host
The function App is hosted in Azure, but there is an issue with Quantum.Simulators library. I have opened the ticket to resolve the same
[Issue](https://github.com/microsoft/Quantum/issues/657):
```
2022-04-20T14:10:09.756 [Error] Executed 'Function1' (Failed, Id=760ab337-5c5d-4975-8a76-950bb62982ae, Duration=41ms)Could not load file or assembly 
'Microsoft.Quantum.Simulators, Version=0.24.0.0, Culture=neutral, PublicKeyToken=40866b40fd95c7f5'.
```
