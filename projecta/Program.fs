module ProjectA

open System.Reflection

let getName() =
    Assembly.GetExecutingAssembly().GetName()
