using System;
using UnityEngine;

public abstract class Controller : MonoBehaviour
{
    [NonSerialized] protected Vector3 direction;

    protected BaseMovementFactory movementFactory; // ������ �� ������� 
    private ITypeMovement typeMovement;  // ������ �� ��������� 

    // ������ �������� ��������� ���������� � ����������
    protected void SetFactory(BaseMovementFactory factory) => movementFactory = factory;
    protected void SetTypeMovement(ITypeMovement movement) => typeMovement = movement;

    // ����� ��� ��������� ������� ��������� ������ (���� ����� ������� ���������)
    protected ITypeMovement GetMovement(EnumMovement enumMovement)
    {
        ITypeMovement typeMovement = movementFactory.GetMovement(enumMovement);  
        if (typeMovement == null)
        {
            Debug.LogError("Error: GetTypeMovement(EnumMovement enumMovement) returns typeMovement == null");
        }
        return typeMovement;    
    }
    
    protected void Move(Vector3 direction) 
    {
        typeMovement.Move(direction); //����� ������ ����� ���������� ���� ���������
    }
}