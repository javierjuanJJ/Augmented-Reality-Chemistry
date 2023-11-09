using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppManagerGame : MonoBehaviour
{
    private Dictionary<char, bool> _dictionaryChemistry;

    private void Awake()
    {
        _dictionaryChemistry = new Dictionary<char, bool>();
    }

    // Start is called before the first frame update
    void Start()
    {
        _dictionaryChemistry.Add('H',false);
        _dictionaryChemistry.Add('O',false);
    }

    public void ElementActivate(string name2)
    {
        _dictionaryChemistry[name2[0]] = true;
    }
    
    
    public void ElementDeactivate(string name2)
    {
        _dictionaryChemistry[name2[0]] = false;
    }
    
    public bool ElementIsActivated(string name2)
    {
        return _dictionaryChemistry[name2[0]];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
