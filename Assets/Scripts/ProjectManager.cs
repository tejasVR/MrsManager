using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ProjectManager : MonoBehaviour
{
    [Header("Large Project")]
    public TextMeshProUGUI rDDeadline;
    public TextMeshProUGUI preProdDeadline;
    public TextMeshProUGUI prodDeadline;
    public TextMeshProUGUI postProdDeadline;

    public enum ProjectType
    {
        Small,
        Medium,
        Large
    }

    public ProjectType projectType;

    public void SetProjectTimeline()
    {      
        SetLargeProjectTimeline();          
    }


    //public void SetProjectTimeline(ProjectType _projectType)
    //{
    //    switch (_projectType)
    //    {
    //        case ProjectType.Large:
    //            SetLargeProjectTimeline();
    //            break;
    //    }
    //}


    private void SetLargeProjectTimeline()
    {
        var currentDate = System.DateTime.Now;

        // Set Research and Discovery
        var rDDate = currentDate.AddDays(14);
        rDDate = SetToWorkWeek(rDDate).Date;
        rDDeadline.text += rDDate.ToString("dddd, dd MMMM yyyy");


        // Set Pre-Production
        var preProdDate = rDDate.AddDays(14);
        preProdDate = SetToWorkWeek(preProdDate);
        preProdDeadline.text += preProdDate.ToString("dddd, dd MMMM yyyy");


        // Set Production
        var prodDate = preProdDate.AddDays(32);
        prodDate = SetToWorkWeek(prodDate);
        prodDeadline.text += prodDate.ToString("dddd, dd MMMM yyyy");


        // Set Post-Production
        var postProdDate = prodDate.AddDays(20);
        postProdDate = SetToWorkWeek(postProdDate);
        postProdDeadline.text += postProdDate.ToString("dddd, dd MMMM yyyy");

    }

    private System.DateTime SetToWorkWeek(System.DateTime _day)
    {
        // Optimize Later

        System.DateTime result;

        while (_day.DayOfWeek == System.DayOfWeek.Saturday || _day.DayOfWeek == System.DayOfWeek.Sunday)
        {
            result = _day.AddDays(1);

            return result;
        }

        return _day;

        //if (_day.DayOfWeek == System.DayOfWeek.Saturday)
        //{
        //    result = _day.AddDays(0);

        //    return _day;
        //}
        //else if (_day.DayOfWeek == System.DayOfWeek.Sunday)
        //{
        //    result =_day.AddDays(3);

        //    //print(_day.Date);

        //    return result;
        //}

        //return _day;


        //while (_day.DayOfWeek == System.DayOfWeek.Saturday || _day.DayOfWeek == System.DayOfWeek.Sunday)
        //{
        //    _day.AddDays(1);

        //    return _day;
        //}

        //return _day;
    }

}
