using System;

// README.md를 읽고 코드를 작성하세요.
int[] scores = { 95, 87, 73, 65, 45, 30 };

Console.WriteLine("=== 성적 평가기 ===");
foreach(int score in scores)
{
    Console.Write($"{score}점: {GetGrade(score)} ({GetStatus(score)}) - ");
    if (IsPassingGrade(score))
    {
        Console.WriteLine($"합격");
    }
    else
    {
        Console.WriteLine($"불합격");
    }
}

string GetGrade(int score) => score switch
{
    >= 90 => "A",
    >= 80 => "B",
    >= 70 => "C",
    >= 60 => "D",
    _ => "F"
};

string GetStatus(int score) => score switch
{
    >= 95 => "최우수",
    >= 90 => "우수",
    >= 70 => "보통",
    >= 40 => "노력 필요",
    _ => "재수강 권장"
};

bool IsPassingGrade(int score) => score is >= 60 and <= 100;