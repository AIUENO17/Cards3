using System.Collections;
using System.Collections.Generic;

public class Card
{

    //カードを配る
    public enum Suit
    {
        Invalid = -1,//-1
        Club,       //0
        Dia,        //1
        Heart,　　　//2
        Spade,      //3
        Max          
    };

    public Suit CardSuit = Suit.Invalid;

    public int Number = 0;

    public const int CardMax = 52;

    public Card(Suit suit, int number)
    {
        CardSuit = suit;
        Number = number;
    }


    //引数の_numに応じて１３までのいずれかを返す
    public static int CardNumJudge(int _num)
    {
        for (int i = 0; i < 13; i++)
        {
            if (_num % 13 == i)
            {
                return i + 1;
            }
        }
        return 0;
    }
    //カードの役を決める１から１３
    //割り算　_numを数字の１３で割る
    public static Suit CardSuitJudge(int _num)
    {
        for (int i = 0; i < (int)Suit.Max; i++)
        {
            if (_num / 13 == i)
            {
                return (Suit)i;
            }
        }
        return Suit.Invalid;
    }
}


