using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
   [SerializeField] private CharacterController m_CharacterController;
   [SerializeField] private Animator m_Animator;
   [SerializeField] private int m_Health;


   private void Start()
   {
      Init();
   }


   private void Init()
   {
      m_CharacterController = GetComponent<CharacterController>();
      m_Health = 100;
   }


   private void Update()
   {
      bool run = m_CharacterController.velocity.magnitude != 0f;
      m_Animator.SetBool("Run",run);
   }


   public bool IsDead()
   {
      m_Health -= 20;
      return m_Health <= 0;
   }
   
   
}
