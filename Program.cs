int i = 1;
while (i <= 5) {
    Console.WriteLine(i);
    i++
}

string input = Console.ReadLine();
while (input != "стоп") {
    Console.WriteLine($"Обработано: {input}");
    input = Console.ReadLine();
}

int sum = 0;
int count = 0;


