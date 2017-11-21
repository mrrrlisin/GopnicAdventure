using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum States
{
    park,
    animals,
    peoples,
    death,
    win
}

public class Adventure : MonoBehaviour
{
    States state = States.park;

    public Text mainText;

    public Image image;

    public Sprite[] images;
	
	void Update ()
	{
        image.sprite = images[(int)state];
        if (state == States.park)
            InPark();
        if (state == States.animals)
            InAnimals();
        if (state == States.peoples)
            InPeoples();
        if (state == States.death)
            InDeath();
        if (state == States.win)
            InWin();
    }

    void InPark()
    {
        mainText.text = "Ты молодой и амбициозный гопник. Ты обитаешь в парке. Тебк нужно решить куда идти:\n\n" +
            " (С) Пойти на север\n (Ю) Пойти на юг";
        if (Input.GetKeyDown(KeyCode.C))
        {
            state = States.peoples;
        }
        if (Input.GetKeyDown(KeyCode.Period))
        {
            Debug.Log(1);
            state = States.animals;
        }
    }

    void InAnimals()
    {
        mainText.text = "Ты идешь на юг и встречаешь стаю голодных голубей."+
            " Это просто голуби - твоя последняя мысль\n Конец\n\n (Р) Рестарт";
        if (Input.GetKeyDown(KeyCode.H))
        {
            state = States.park;
        } 
    }

    void InPeoples()
    {
        mainText.text = "Ты идешь на север. Перед тобой много людей и потенциальная жертва:\n\n" +
            " (П) Попросить на пиво\n (З) Попросить позвонить";
        if (Input.GetKeyDown(KeyCode.G))
        {
            state = States.death;
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            state = States.win;
        }
    }

    void InDeath()
    {
        mainText.text = "Вот тебе на пиво отвечает человек. Это последнее что ты слышишь." +
            "Конец\n\n (Р) Рестарт";
        if (Input.GetKeyDown(KeyCode.H))
        {
            state = States.park;
        }
    }

    void InWin()
    {
        mainText.text = "Доверчивый простак отдает тебе телефон. Ты победил" +
            "Конец\n\n (Р) Рестарт";
        if (Input.GetKeyDown(KeyCode.H))
        {
            state = States.park;
        }
    }
}
