Imports System.Console
Module Module1
    Dim selector As Integer
    Dim resposta As Integer
    Dim resposta2 As Integer
    Dim contador As Integer
    Dim contador2 As Integer



    Sub Main()
        Console.ForegroundColor = ConsoleColor.Magenta
        WriteLine(Space(75) & "***** GAME *****")



        WriteLine(Space(72) & "CHOOSE THE QUIZ'S THEME")

        Console.ForegroundColor = ConsoleColor.DarkYellow
        WriteLine("1 --- GENERAL CULTURE")
        WriteLine("2 --- SPORTS")
        WriteLine("3 --- TECHNOLOGY")
        WriteLine()
        WriteLine("Choose your theme: ")
        selector = ReadLine()
        WriteLine()

        Do While contador < 2 Or contador2 < 2




            Select Case selector

                Case 1
                    '1 pergunta
                    Console.ForegroundColor = ConsoleColor.Magenta
                    WriteLine("RULES:")
                    WriteLine()
                    Console.ForegroundColor = ConsoleColor.Cyan
                    WriteLine("Answer the Questions correctly, to get 1 point, first player to reach 2 points wins.")
                    WriteLine()
                    Console.ForegroundColor = ConsoleColor.DarkYellow
                    WriteLine("Wich country has the largest population?")
                    WriteLine()
                    WriteLine("1 --- Russia")
                    WriteLine("2 --- Portugal")
                    WriteLine("3 --- India")
                    WriteLine("4 --- China")
                    WriteLine()
                    WriteLine("User 1 choose your answer.")
                    resposta = ReadLine()
                    WriteLine()
                    WriteLine("User 2 choose your answer.")
                    resposta2 = ReadLine()
                    WriteLine()

                    If resposta = 4 Then
                        Console.ForegroundColor = ConsoleColor.Green
                        WriteLine("User 1 chose the correct answer.")
                        contador += 1

                    Else Console.ForegroundColor = ConsoleColor.DarkRed
                        WriteLine("Unfortunately user 1 Failed, better luck next time")
                    End If

                    If resposta2 = 4 Then
                        Console.ForegroundColor = ConsoleColor.Green
                        WriteLine("User 2 chose the correct answer.")
                        contador2 += 1

                    Else Console.ForegroundColor = ConsoleColor.DarkRed
                        WriteLine("Unfortunately user 2 Failed, better luck next time")
                    End If
                    WriteLine()
                    Console.ForegroundColor = ConsoleColor.Magenta
                    WriteLine(Space(90) & "User 1 has " & contador & " Points")
                    WriteLine(Space(90) & "User 2 has " & contador2 & " Points")
                    ReadLine()


                    WriteLine()


                    '2 pergunta
                    Console.ForegroundColor = ConsoleColor.DarkYellow
                    WriteLine("Who was the first man to step on the moon?")
                    WriteLine()
                    WriteLine("1 --- Yuri Gagarin")
                    WriteLine("2 --- Neil Armstrong")
                    WriteLine("3 --- Buzz Aldrin")
                    WriteLine("4 --- James Irwin")
                    WriteLine()
                    WriteLine("User 1 choose your answer.")
                    resposta = ReadLine()
                    WriteLine()
                    WriteLine("User 2 choose your answer.")
                    resposta2 = ReadLine()
                    WriteLine()

                    If resposta = 2 Then
                        Console.ForegroundColor = ConsoleColor.Green
                        WriteLine("User 1 chose the correct answer.")
                        contador += 1

                    Else Console.ForegroundColor = ConsoleColor.DarkRed
                        WriteLine("Unfortunately user 1 Failed, better luck next time")
                    End If

                    If resposta2 = 2 Then
                        Console.ForegroundColor = ConsoleColor.Green
                        WriteLine("User 2 chose the correct answer.")
                        contador2 += 1


                    Else
                        Console.ForegroundColor = ConsoleColor.DarkRed
                        WriteLine("Unfortunately user 2 Failed, better luck next time")

                    End If
                    If contador = 2 Or contador2 = 2 Then
                        Exit Do
                    End If
                    WriteLine()
                    Console.ForegroundColor = ConsoleColor.Magenta
                    WriteLine(Space(90) & "User 1 has " & contador & " Points")
                    WriteLine(Space(90) & "User 2 has " & contador2 & " Points")
                    ReadLine()

                    WriteLine()
                    '3 pergunta
                    Console.ForegroundColor = ConsoleColor.DarkYellow
                    WriteLine("Who wrote the Art of War?")
                    WriteLine()
                    WriteLine("1 --- Sun Tzu")
                    WriteLine("2 --- Mao Tsé Tung")
                    WriteLine("3 --- Gandhi")
                    WriteLine("4 --- Confúcio")
                    WriteLine()
                    WriteLine("User 1 choose your answer.")
                    resposta = ReadLine()
                    WriteLine()
                    WriteLine("User 2 choose your answer.")
                    resposta2 = ReadLine()
                    WriteLine()

                    If resposta = 1 Then
                        Console.ForegroundColor = ConsoleColor.Green
                        WriteLine("User 1 chose the correct answer.")
                        contador += 1

                    Else
                        Console.ForegroundColor = ConsoleColor.DarkRed
                        WriteLine("Unfortunately user 1 Failed, better luck next time")
                    End If

                    If resposta2 = 1 Then
                        Console.ForegroundColor = ConsoleColor.Green
                        WriteLine("User 2 chose the correct answer.")
                        contador2 += 1

                    Else
                        Console.ForegroundColor = ConsoleColor.DarkRed
                        WriteLine("Unfortunately user 2 Failed, better luck next time")
                    End If
                    If contador = 2 Or contador2 = 2 Then
                        Exit Do
                    End If


                    WriteLine()
                    Console.ForegroundColor = ConsoleColor.Magenta
                    WriteLine(Space(90) & "User 1 has " & contador & " Points")
                    WriteLine(Space(90) & "User 2 has " & contador2 & " Points")
                    ReadLine()


                    WriteLine()
                    '4 pergunta
                    Console.ForegroundColor = ConsoleColor.DarkYellow
                    WriteLine("Who is known for this sentence? : I think, therefore I exist. ")
                    WriteLine()
                    WriteLine("1 --- Descartes")
                    WriteLine("2 --- Galileu Galilei")
                    WriteLine("3 --- Sócrates")
                    WriteLine("4 --- Plato")
                    WriteLine()
                    WriteLine("User 1 choose your answer.")
                    resposta = ReadLine()
                    WriteLine()
                    WriteLine("User 2 choose your answer.")
                    resposta2 = ReadLine()
                    WriteLine()

                    If resposta = 1 Then
                        Console.ForegroundColor = ConsoleColor.Green
                        WriteLine("User 1 chose the correct answer.")
                        contador += 1

                    Else
                        Console.ForegroundColor = ConsoleColor.DarkRed
                        WriteLine("Unfortunately user 1 Failed, better luck next time")
                    End If

                    If resposta2 = 1 Then
                        Console.ForegroundColor = ConsoleColor.Green
                        WriteLine("User 2 chose the correct answer.")
                        contador2 += 1

                    Else
                        Console.ForegroundColor = ConsoleColor.DarkRed
                        WriteLine("Unfortunately user 2 Failed, better luck next time")
                    End If
                    If contador = 2 Or contador2 = 2 Then
                        Exit Do
                    End If
                    WriteLine()
                    Console.ForegroundColor = ConsoleColor.Magenta
                    WriteLine(Space(90) & "User 1 has " & contador & " Points")
                    WriteLine(Space(90) & "User 2 has " & contador2 & " Points")
                    ReadLine()
                    WriteLine()

                    '5 pergunta'
                    Console.ForegroundColor = ConsoleColor.DarkYellow
                    WriteLine("Who was the first Portuguese King?")
                    WriteLine()
                    WriteLine("1 --- D.João I")
                    WriteLine("2 --- D. Afonso Henriques")
                    WriteLine("3 --- D. Sebastião")
                    WriteLine("4 --- D. Duarte I")
                    WriteLine()
                    WriteLine("User 1 choose your answer.")
                    resposta = ReadLine()
                    WriteLine()
                    WriteLine("User 2 choose your answer.")
                    resposta2 = ReadLine()
                    WriteLine()

                    If resposta = 2 Then
                        Console.ForegroundColor = ConsoleColor.Green
                        WriteLine("User 1 chose the correct answer.")
                        contador += 1

                    Else
                        Console.ForegroundColor = ConsoleColor.DarkRed
                        WriteLine("Unfortunately user 1 Failed, better luck next time")
                    End If

                    If resposta2 = 2 Then
                        Console.ForegroundColor = ConsoleColor.Green
                        WriteLine("User 2 chose the correct answer.")
                        contador2 += 1

                    Else
                        Console.ForegroundColor = ConsoleColor.DarkRed
                        WriteLine("Unfortunately user 2 Failed, better luck next time")
                    End If
                    If contador = 2 Or contador2 = 2 Then
                        Exit Do
                    End If
                    WriteLine()
                    Console.ForegroundColor = ConsoleColor.Magenta
                    WriteLine(Space(90) & "User 1 has " & contador & " Points")
                    WriteLine(Space(90) & "User 2 has " & contador2 & " Points")
                    ReadLine()
                    ' Fim do primeiro tema '

                    'Segundo tema'
                Case 2
                    'Primeira Pergunta do segundo tema'
                    Console.ForegroundColor = ConsoleColor.Magenta
                    WriteLine("RULES:")
                    WriteLine()
                    Console.ForegroundColor = ConsoleColor.Cyan
                    WriteLine("Answer the Questions correctly, to get 1 point, first player to reach 2 points wins.")
                    WriteLine()
                    Console.ForegroundColor = ConsoleColor.DarkYellow
                    WriteLine("Wich basketball brand is used in official basketball games?")
                    WriteLine()
                    WriteLine("1 --- Nike")
                    WriteLine("2 --- Adidas")
                    WriteLine("3 --- Spalding")
                    WriteLine("4 --- Wilson")
                    WriteLine()
                    WriteLine("User 1 choose your answer.")
                    resposta = ReadLine()
                    WriteLine()
                    WriteLine("User 2 choose your answer.")
                    resposta2 = ReadLine()
                    WriteLine()

                    If resposta = 3 Then
                        Console.ForegroundColor = ConsoleColor.Green
                        WriteLine("User 1 chose the correct answer.")
                        contador += 1

                    Else Console.ForegroundColor = ConsoleColor.DarkRed
                        WriteLine("Unfortunately user 1 Failed, better luck next time")
                    End If

                    If resposta2 = 3 Then
                        Console.ForegroundColor = ConsoleColor.Green
                        WriteLine("User 2 chose the correct answer.")
                        contador2 += 1

                    Else Console.ForegroundColor = ConsoleColor.DarkRed
                        WriteLine("Unfortunately user 2 Failed, better luck next time")
                    End If
                    If contador = 2 Or contador2 = 2 Then
                        Exit Do
                    End If
                    WriteLine()
                    Console.ForegroundColor = ConsoleColor.Magenta
                    WriteLine(Space(90) & "User 1 has " & contador & " Points")
                    WriteLine(Space(90) & "User 2 has " & contador2 & " Points")
                    ReadLine()


                    WriteLine()
                    'Segunda pergunta'
                    Console.ForegroundColor = ConsoleColor.DarkYellow
                    WriteLine("Wich is the most played game in the world?")
                    WriteLine()
                    WriteLine("1 --- Basketball")
                    WriteLine("2 --- American Football")
                    WriteLine("3 --- Football")
                    WriteLine("4 --- Golf")
                    WriteLine()
                    WriteLine("User 1 choose your answer.")
                    resposta = ReadLine()
                    WriteLine()
                    WriteLine("User 2 choose your answer.")
                    resposta2 = ReadLine()
                    WriteLine()

                    If resposta = 3 Then
                        Console.ForegroundColor = ConsoleColor.Green
                        WriteLine("User 1 chose the correct answer.")
                        contador += 1

                    Else Console.ForegroundColor = ConsoleColor.DarkRed
                        WriteLine("Unfortunately user 1 Failed, better luck next time")
                    End If

                    If resposta2 = 3 Then
                        Console.ForegroundColor = ConsoleColor.Green
                        WriteLine("User 2 chose the correct answer.")
                        contador2 += 1

                    Else Console.ForegroundColor = ConsoleColor.DarkRed
                        WriteLine("Unfortunately user 2 Failed, better luck next time")
                    End If
                    If contador = 2 Or contador2 = 2 Then
                        Exit Do
                    End If
                    WriteLine()
                    Console.ForegroundColor = ConsoleColor.Magenta
                    WriteLine(Space(90) & "User 1 has " & contador & " Points")
                    WriteLine(Space(90) & "User 2 has " & contador2 & " Points")
                    ReadLine()

                    WriteLine()

                    '3a Pergunta'

                    Console.ForegroundColor = ConsoleColor.DarkYellow
                    WriteLine("Who holds the record for most goals in football?")
                    WriteLine()
                    WriteLine("1 --- Cristiano Ronaldo")
                    WriteLine("2 --- Josef Bican")
                    WriteLine("3 --- Ferenc Puskás")
                    WriteLine("4 --- Lionel Messi")
                    WriteLine()
                    WriteLine("User 1 choose your answer.")
                    resposta = ReadLine()
                    WriteLine()
                    WriteLine("User 2 choose your answer.")
                    resposta2 = ReadLine()
                    WriteLine()

                    If resposta = 2 Then
                        Console.ForegroundColor = ConsoleColor.Green
                        WriteLine("User 1 chose the correct answer.")
                        contador += 1

                    Else Console.ForegroundColor = ConsoleColor.DarkRed
                        WriteLine("Unfortunately user 1 Failed, better luck next time")
                    End If

                    If resposta2 = 2 Then
                        Console.ForegroundColor = ConsoleColor.Green
                        WriteLine("User 2 chose the correct answer.")
                        contador2 += 1

                    Else Console.ForegroundColor = ConsoleColor.DarkRed
                        WriteLine("Unfortunately user 2 Failed, better luck next time")
                    End If
                    If contador = 2 Or contador2 = 2 Then
                        Exit Do
                    End If
                    WriteLine()
                    Console.ForegroundColor = ConsoleColor.Magenta
                    WriteLine(Space(90) & "User 1 has " & contador & " Points")
                    WriteLine(Space(90) & "User 2 has " & contador2 & " Points")
                    ReadLine()

                    WriteLine()

                    'quarta pergunta'
                    Console.ForegroundColor = ConsoleColor.DarkYellow
                    WriteLine("Who has the most gold medals in the swimming category?")
                    WriteLine()
                    WriteLine("1 --- Jenny Thompson")
                    WriteLine("2 --- Mark Spitz")
                    WriteLine("3 --- Alexander Popov")
                    WriteLine("4 --- Michael Phelps")
                    WriteLine()
                    WriteLine("User 1 choose your answer.")
                    resposta = ReadLine()
                    WriteLine()
                    WriteLine("User 2 choose your answer.")
                    resposta2 = ReadLine()
                    WriteLine()

                    If resposta = 4 Then
                        Console.ForegroundColor = ConsoleColor.Green
                        WriteLine("User 1 chose the correct answer.")
                        contador += 1

                    Else Console.ForegroundColor = ConsoleColor.DarkRed
                        WriteLine("Unfortunately user 1 Failed, better luck next time")
                    End If

                    If resposta2 = 4 Then
                        Console.ForegroundColor = ConsoleColor.Green
                        WriteLine("User 2 chose the correct answer.")
                        contador2 += 1

                    Else Console.ForegroundColor = ConsoleColor.DarkRed
                        WriteLine("Unfortunately user 2 Failed, better luck next time")
                    End If
                    If contador = 2 Or contador2 = 2 Then
                        Exit Do
                    End If
                    WriteLine()
                    Console.ForegroundColor = ConsoleColor.Magenta
                    WriteLine(Space(90) & "User 1 has " & contador & " Points")
                    WriteLine(Space(90) & "User 2 has " & contador2 & " Points")
                    ReadLine()

                    WriteLine()
                    'Quinta Pergunta'
                    Console.ForegroundColor = ConsoleColor.DarkYellow
                    WriteLine("Who holds the record for the most nba titles?")
                    WriteLine()
                    WriteLine("1 --- Bill Russel")
                    WriteLine("2 --- Scottie Pippen")
                    WriteLine("3 --- Michael Jordan")
                    WriteLine("4 --- Lebron James")
                    WriteLine()
                    WriteLine("User 1 choose your answer.")
                    resposta = ReadLine()
                    WriteLine()
                    WriteLine("User 2 choose your answer.")
                    resposta2 = ReadLine()
                    WriteLine()

                    If resposta = 1 Then
                        Console.ForegroundColor = ConsoleColor.Green
                        WriteLine("User 1 chose the correct answer.")
                        contador += 1

                    Else Console.ForegroundColor = ConsoleColor.DarkRed
                        WriteLine("Unfortunately user 1 Failed, better luck next time")
                    End If

                    If resposta2 = 1 Then
                        Console.ForegroundColor = ConsoleColor.Green
                        WriteLine("User 2 chose the correct answer.")
                        contador2 += 1

                    Else Console.ForegroundColor = ConsoleColor.DarkRed
                        WriteLine("Unfortunately user 2 Failed, better luck next time")
                    End If
                    If contador = 2 Or contador2 = 2 Then
                        Exit Do
                    End If
                    WriteLine()
                    Console.ForegroundColor = ConsoleColor.Magenta
                    WriteLine(Space(90) & "User 1 has " & contador & " Points")
                    WriteLine(Space(90) & "User 2 has " & contador2 & " Points")
                    ReadLine()

                    ' Fim do Segundo tema'

                    'Inicio do terceiro tema'
                Case 3

                    Console.ForegroundColor = ConsoleColor.Magenta
                    WriteLine("RULES:")
                    WriteLine()
                    Console.ForegroundColor = ConsoleColor.Cyan
                    WriteLine("Answer the Questions correctly, to get 1 point, first player to reach 2 points wins.")
                    WriteLine()
                    Console.ForegroundColor = ConsoleColor.DarkYellow
                    WriteLine("Wich operative system has the most market share?")
                    WriteLine()
                    WriteLine("1 --- Android")
                    WriteLine("2 --- Windows")
                    WriteLine("3 --- iOS")
                    WriteLine("4 --- OS X")
                    WriteLine()
                    WriteLine("User 1 choose your answer.")
                    resposta = ReadLine()
                    WriteLine()
                    WriteLine("User 2 choose your answer.")
                    resposta2 = ReadLine()
                    WriteLine()

                    If resposta = 1 Then
                        Console.ForegroundColor = ConsoleColor.Green
                        WriteLine("User 1 chose the correct answer.")
                        contador += 1

                    Else Console.ForegroundColor = ConsoleColor.DarkRed
                        WriteLine("Unfortunately user 1 Failed, better luck next time")
                    End If

                    If resposta2 = 1 Then
                        Console.ForegroundColor = ConsoleColor.Green
                        WriteLine("User 2 chose the correct answer.")
                        contador2 += 1

                    Else Console.ForegroundColor = ConsoleColor.DarkRed
                        WriteLine("Unfortunately user 2 Failed, better luck next time")
                    End If
                    If contador = 2 Or contador2 = 2 Then
                        Exit Do
                    End If
                    WriteLine()
                    Console.ForegroundColor = ConsoleColor.Magenta
                    WriteLine(Space(90) & "User 1 has " & contador & " Points")
                    WriteLine(Space(90) & "User 2 has " & contador2 & " Points")
                    ReadLine()


                    WriteLine()
                    'segunda pergunta'
                    Console.ForegroundColor = ConsoleColor.DarkYellow
                    WriteLine("What was the first programming language?")
                    WriteLine()
                    WriteLine("1 --- Visual Basic")
                    WriteLine("2 --- C++")
                    WriteLine("3 --- Plankalkül")
                    WriteLine("4 --- JavaScript")
                    WriteLine()
                    WriteLine("User 1 choose your answer.")
                    resposta = ReadLine()
                    WriteLine()
                    WriteLine("User 2 choose your answer.")
                    resposta2 = ReadLine()
                    WriteLine()

                    If resposta = 3 Then
                        Console.ForegroundColor = ConsoleColor.Green
                        WriteLine("User 1 chose the correct answer.")
                        contador += 1

                    Else Console.ForegroundColor = ConsoleColor.DarkRed
                        WriteLine("Unfortunately user 1 Failed, better luck next time")
                    End If

                    If resposta2 = 3 Then
                        Console.ForegroundColor = ConsoleColor.Green
                        WriteLine("User 2 chose the correct answer.")
                        contador2 += 1

                    Else Console.ForegroundColor = ConsoleColor.DarkRed
                        WriteLine("Unfortunately user 2 Failed, better luck next time")
                    End If
                    If contador = 2 Or contador2 = 2 Then
                        Exit Do
                    End If
                    WriteLine()
                    Console.ForegroundColor = ConsoleColor.Magenta
                    WriteLine(Space(90) & "User 1 has " & contador & " Points")
                    WriteLine(Space(90) & "User 2 has " & contador2 & " Points")
                    ReadLine()


                    WriteLine()
                    'terceira pergunta'
                    Console.ForegroundColor = ConsoleColor.DarkYellow
                    WriteLine("Who was the world's first hacker")
                    WriteLine()
                    WriteLine("1 --- Anonymous")
                    WriteLine("2 --- Kevin Mitnick")
                    WriteLine("3 --- Adrian Lamo")
                    WriteLine("4 --- Albert Gonzalez")
                    WriteLine()
                    WriteLine("User 1 choose your answer.")
                    resposta = ReadLine()
                    WriteLine()
                    WriteLine("User 2 choose your answer.")
                    resposta2 = ReadLine()
                    WriteLine()

                    If resposta = 2 Then
                        Console.ForegroundColor = ConsoleColor.Green
                        WriteLine("User 1 chose the correct answer.")
                        contador += 1

                    Else Console.ForegroundColor = ConsoleColor.DarkRed
                        WriteLine("Unfortunately user 1 Failed, better luck next time")
                    End If

                    If resposta2 = 2 Then
                        Console.ForegroundColor = ConsoleColor.Green
                        WriteLine("User 2 chose the correct answer.")
                        contador2 += 1

                    Else Console.ForegroundColor = ConsoleColor.DarkRed
                        WriteLine("Unfortunately user 2 Failed, better luck next time")
                    End If
                    If contador = 2 Or contador2 = 2 Then
                        Exit Do
                    End If
                    WriteLine()
                    Console.ForegroundColor = ConsoleColor.Magenta
                    WriteLine(Space(90) & "User 1 has " & contador & " Points")
                    WriteLine(Space(90) & "User 2 has " & contador2 & " Points")
                    ReadLine()

                    WriteLine()
                    'quarta pergunta'
                    Console.ForegroundColor = ConsoleColor.DarkYellow
                    WriteLine("Wich is the most visited website?")
                    WriteLine()
                    WriteLine("1 --- google.com")
                    WriteLine("2 --- youtube.com")
                    WriteLine("3 --- facebook.com")
                    WriteLine("4 --- wikipedia.org")
                    WriteLine()
                    WriteLine("User 1 choose your answer.")
                    resposta = ReadLine()
                    WriteLine()
                    WriteLine("User 2 choose your answer.")
                    resposta2 = ReadLine()
                    WriteLine()

                    If resposta = 1 Then
                        Console.ForegroundColor = ConsoleColor.Green
                        WriteLine("User 1 chose the correct answer.")
                        contador += 1

                    Else Console.ForegroundColor = ConsoleColor.DarkRed
                        WriteLine("Unfortunately user 1 Failed, better luck next time")
                    End If

                    If resposta2 = 1 Then
                        Console.ForegroundColor = ConsoleColor.Green
                        WriteLine("User 2 chose the correct answer.")
                        contador2 += 1

                    Else Console.ForegroundColor = ConsoleColor.DarkRed
                        WriteLine("Unfortunately user 2 Failed, better luck next time")
                    End If
                    If contador = 2 Or contador2 = 2 Then
                        Exit Do
                    End If
                    WriteLine()
                    Console.ForegroundColor = ConsoleColor.Magenta
                    WriteLine(Space(90) & "User 1 has " & contador & " Points")
                    WriteLine(Space(90) & "User 2 has " & contador2 & " Points")
                    ReadLine()

                    WriteLine()

                    Console.ForegroundColor = ConsoleColor.DarkYellow
                    WriteLine("In wich year was Microsoft founded?")
                    WriteLine()
                    WriteLine("1 --- 1973")
                    WriteLine("2 --- 1974")
                    WriteLine("3 --- 1975")
                    WriteLine("4 --- 1976")
                    WriteLine()
                    WriteLine("User 1 choose your answer.")
                    resposta = ReadLine()
                    WriteLine()
                    WriteLine("User 2 choose your answer.")
                    resposta2 = ReadLine()
                    WriteLine()

                    If resposta = 3 Then
                        Console.ForegroundColor = ConsoleColor.Green
                        WriteLine("User 1 chose the correct answer.")
                        contador += 1

                    Else Console.ForegroundColor = ConsoleColor.DarkRed
                        WriteLine("Unfortunately user 1 Failed, better luck next time")
                    End If

                    If resposta2 = 3 Then
                        Console.ForegroundColor = ConsoleColor.Green
                        WriteLine("User 2 chose the correct answer.")
                        contador2 += 1

                    Else Console.ForegroundColor = ConsoleColor.DarkRed
                        WriteLine("Unfortunately user 2 Failed, better luck next time")
                    End If
                    If contador = 2 Or contador2 = 2 Then
                        Exit Do
                    End If
                    WriteLine()
                    Console.ForegroundColor = ConsoleColor.Magenta
                    WriteLine(Space(90) & "User 1 has " & contador & " Points")
                    WriteLine(Space(90) & "User 2 has " & contador2 & " Points")
                    ReadLine()





            End Select
        Loop
        ReadLine()

        If contador = contador2 Then
            WriteLine("Both Players ended up tied.")
        ElseIf contador > contador2 Then
            WriteLine("User1 Won")
        ElseIf contador < contador2 Then
            WriteLine("User2 Won")

        End If
        ReadLine()

    End Sub

End Module
