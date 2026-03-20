
open System
// Номер 1 
(*
let rec getSeq() = seq {
    let s = Console.ReadLine()
    if not (String.IsNullOrWhiteSpace(s)) then 
        if Char.IsDigit(s.[0]) && s.Length = 1 then
            let n = int s
            if n >= 1 && n <= 7 then
                yield n            
                yield! getSeq()    
            else
                printfn "Ошибка"
                yield! getSeq()
        else
            printfn "Ошибка" 
            yield! getSeq()
}


let toDayName n = 
    match n with

    | 1 -> "Понедельник"
    | 2 -> "Вторник"
    | 3 -> "Среда"

    | 4 -> "Четверг"
    | 5 -> "Пятница"
    | 6 -> "Суббота"

    | 7 -> "Воскресенье"
    | _ -> "Неизвестно"

[<EntryPoint>]
let main args = 
    printfn "Вводите числа от 1 до 7 (пустая строка для завершения):"
    
    let numbers = getSeq()
    let dayNames = numbers |> Seq.map toDayName

    dayNames |> Seq.iter (fun day -> printfn "День: %s" day)

    0
 *)
//Номер 2
(*
let countDigits (n: int) =
    abs(n).ToString().Length

let countNumbersWithKDigits (numbers: seq<int>) k =
    numbers

    |> Seq.fold (fun acc x -> 
        if countDigits x = k then acc + 1 else acc
    ) 0

[<EntryPoint>]
let main argv =
    printf "Введите числа через пробел: "
    let input = Console.ReadLine()
    
    printf "Введите k (искомое количество цифр): "
    let kStr = Console.ReadLine()

    try
        let k = int kStr
        let numbers = 
            input.Split([|' '|],StringSplitOptions.RemoveEmptyEntries) 
            |> Seq.map int

        let result = countNumbersWithKDigits numbers k
        
        printfn "Количество чисел, содержащих %d цифр: %d" k result
    with
    | :? FormatException -> printfn "Ошибка: вводите только целые числа!"
    
    0

*)
//Номер 3
(*
open System
open System.IO

let countDirsByFirstChar path startChar =
    try
        Directory.GetDirectories(path)
        |> Seq.filter (fun dir -> 
            let name = Path.GetFileName(dir)
            not (String.IsNullOrEmpty(name))&&name.[0]=startChar
        )
        |> Seq.length
    with
    | _ -> -1

[<EntryPoint>]
let main argv =
    printf "Путь: "
    let path = Console.ReadLine()
    printf "Символ: "
    let ch = Console.ReadLine()
    
    if String.IsNullOrEmpty(ch) then
        printfn "Ошибка: символ не указан"
    else
        match countDirsByFirstChar path ch.[0] with
        | count when count >= 0 -> 
            printfn "Найдено каталогов: %d" count
        | _ -> 
            printfn "Ошибка при доступе к каталогу"
    
    0
*)

