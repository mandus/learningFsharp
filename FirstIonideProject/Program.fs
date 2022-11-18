// For more information see https://aka.ms/fsharp-console-apps

// Starting at https://learn.microsoft.com/en-us/dotnet/fsharp/get-started/get-started-vscode

// printfn "Hello from F#"

module PigLatin = 
    let toPigLatin (word: string) = 
        let isVowel (c: char)  = 
            match c with
            | 'a' | 'e' | 'i' | 'o' | 'u'
            | 'A' | 'E' | 'I' | 'O' | 'U' -> true
            |_ -> false
        
        if isVowel word[0] then
            word + "yay"
        else
            word[1..] + string(word[0]) + "ay"

[<EntryPoint>]
let main args = 
    for arg in args do
        let pigArg = PigLatin.toPigLatin arg
        printfn "%s in Pig Latin is: %s" arg pigArg
    0 // Need to end with a zero (or some other int) since main should return int.