
using UnityEngine;

public class Square : ScriptableObject
{
    // Реализуйте публичный метод Proccess
    // который принимает на вход сторону квадрата (вещественное число)
    // и возвращает площадь квадарта (вещественное)

    public float Proccess(float a) {
        return a*a;
    }

    //

    // 4 / 2 = 2
    // 6 / 2 = 3

    // 4 % 2 = 0
    // 3 % 2 = 1
    // 5 % 2 = 1
    // 6 % 2 = 0
    // 7 % 2 = 1
    // ....
    public string IsMoreThanFive(int number) {
        if (number > 5) {
            return "Больше 5";
        }

        return "Меньше или равно 5";
    }
}
