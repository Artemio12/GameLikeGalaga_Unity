using System.Collections.Generic;
using UnityEngine;

public class PoolMono<T> where T : Rigidbody
{
    private Transform container;

    private T prefab;

    //private bool autoExpand;
    public bool AutoExpand { get; set; }

    private List<T> pool;
    
    public PoolMono(Transform container)
    {
        this.container = container;
    }

    public PoolMono(Transform container, T prefab, int count): this (container)
    {
        this.prefab = prefab;

        this.CreatePool(count);
    }

    private void CreatePool(int count)
    {
        pool = new List<T>();
        for (int i = 0; i < count; i++)
        {
            this.CreateObject();
        }
    }

    private T CreateObject(bool isActiveByDefolt = false)
    {
        var createdObject = GameObject.Instantiate(prefab, container); //�������� ������� 
        createdObject.gameObject.SetActive(isActiveByDefolt);  // ��������� ��� ���������� �� ������� ����������
        this.pool.Add(createdObject); // ���������� � ���
        return createdObject;
    }

    public bool HasFreeElement(out T element)
    {
        foreach (var mono in pool) 
        {
            if (!mono.gameObject.activeInHierarchy)
            {
                element = mono;
                mono.gameObject.SetActive(true);
                return true;
            }
        }
        element = null;
        return false;
    }

    public T GetFreeElement() 
    {
        // ��������� ������� ������ �� ����, ���� ���� ��������� ������
        if (this.HasFreeElement(out T element)) return element;

        // ���� ��� ���������������, ������� ������ � ���������� ���
        if (this.AutoExpand) return this.CreateObject(true);

        throw new System.Exception($"There is no free elements in pool of type{typeof(T)}");
    }

    //���������� GetFreeElement(), ����������� ������� ������ �� ���� � ������� ������������
    public T GetFreeElement(Vector3 position) 
    {
        var element = GetFreeElement();
        element.transform.position = position;
        return element;
    }

    //���������� GetFreeElement(), ����������� ������� ������ �� ���� � ������� ������������ � ����� ��������
    public T GetFreeElement(Vector3 position, Quaternion rotation) 
    {
        var element = GetFreeElement();
        element.transform.position = position;
        element.transform.rotation = rotation;
        return element;
    }

}
