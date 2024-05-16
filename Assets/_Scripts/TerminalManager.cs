using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TerminalManager : MonoBehaviour
{
    public GameObject directoryLine;
    public GameObject responseLine;
    public GameObject ObejetoMenuPausa;
    public bool Pausa = false;

    public InputField terminalInput;
    public GameObject userInputLine;
    public ScrollRect sr;
    public GameObject msgList;
    public Interp interpreter;
    public MenuInterfaz mi;

    private void Start()
    {
        interpreter = GameObject.Find("Player").GetComponent<Interp>();
        mi = GameObject.Find("Interfaz").GetComponent<MenuInterfaz>();
    }

    public void Abrimenu(bool iniciar)
    {
        if (iniciar == true)
        {

            if (Pausa == false)
            {
                ObejetoMenuPausa.SetActive(true);


                Pausa = true;

                Time.timeScale = 0;
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
                GameObject.Find("Player").GetComponent<PlayerController>().enabled = false;

            }
        }
    }
    public void Resumir()
    {
       
        ObejetoMenuPausa.SetActive(false);
        Pausa = false;
        
        Time.timeScale = 1;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        GameObject.Find("Player").GetComponent<PlayerController>().enabled = true;
        mi.Reutilizar();
        
        
    }
    public void Reutilizar()
    {

        ObejetoMenuPausa.SetActive(false);
        Pausa = false;

    }


    private void OnGUI()
    {
        if(terminalInput.isFocused && terminalInput.text != "" && Input.GetKeyDown(KeyCode.Return))
        {
            string userInput = terminalInput.text;

            ClearInputField();

            AddDirectoryLine(userInput);


            int lines = AddInterpreterLines(interpreter.Interpret(userInput));

            ScrollToBottom(lines);


            userInputLine.transform.SetAsLastSibling();

            terminalInput.ActivateInputField();
            terminalInput.Select();
        }
    }

    void ClearInputField()
    {
        terminalInput.text = "";
    }
    void AddDirectoryLine(string userInput)
    {
        Vector2 msgListSize = msgList.GetComponent<RectTransform>().sizeDelta;
        msgList.GetComponent<RectTransform>().sizeDelta = new Vector2(msgListSize.x, msgListSize.y + 35.0f);


        GameObject msg = Instantiate(directoryLine, msgList.transform);

        msg.transform.SetSiblingIndex(msgList.transform.childCount - 1);

        msg.GetComponentsInChildren<Text>()[1].text = userInput;


    }

    int AddInterpreterLines(List<string> interpretation)
    {
        for(int i = 0; i < interpretation.Count; i++)
        {
            GameObject res = Instantiate(responseLine, msgList.transform);

            res.transform.SetAsLastSibling();

            Vector2 listSize = msgList.GetComponent<RectTransform>().sizeDelta;
            msgList.GetComponent<RectTransform>().sizeDelta = new Vector2(listSize.x, listSize.y + 35.0f);

            res.GetComponentInChildren<Text>().text = interpretation[i];

        }

        return interpretation.Count;
    }

    void ScrollToBottom(int lines)
    {
        if(lines > 20)
        {
            sr.velocity = new Vector2(0, 450);
        }
        else
        {
            sr.verticalNormalizedPosition = 0;
        }
    }

}