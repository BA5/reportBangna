using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace reportBangna.objdb
{
    public class reportDB
    {
        public ConnectDB conn{get;set;}
        public reportDB(ConnectDB c)
        {
            conn = c;
        }
        public DataTable xraySummary(DateTime dateStart, DateTime dateEnd)
        {
            DataTable dt = new DataTable();
            String sql = "";
            //sql = "SELECT        XRAY_T01.MNC_HN_YR, XRAY_T01.MNC_HN_NO, PATIENT_M02.MNC_PFIX_DSC, PATIENT_M01.MNC_FNAME_T, PATIENT_M01.MNC_LNAME_T, " +
            //             "XRAY_T01.MNC_REQ_YR, XRAY_T01.MNC_REQ_NO, XRAY_T01.MNC_REQ_DAT, PHARMACY_M01.MNC_PH_CD, XRAY_T05.MNC_XR_USE, "+
            //             "XRAY_T05.MNC_XR_BAD, PHARMACY_M01.MNC_PH_TN, XRAY_M01.MNC_XR_DSC, XRAY_T01.MNC_REQ_STS "+
            //            "   FROM            XRAY_T05 INNER JOIN "+
            //             "XRAY_T01 ON XRAY_T05.MNC_REQ_YR = XRAY_T01.MNC_REQ_YR AND XRAY_T05.MNC_REQ_NO = XRAY_T01.MNC_REQ_NO INNER JOIN "+
            //             "PHARMACY_M01 ON XRAY_T05.MNC_PH_CD = PHARMACY_M01.MNC_PH_CD INNER JOIN "+
            //             "PATIENT_M01 ON XRAY_T01.MNC_HN_YR = PATIENT_M01.MNC_HN_YR AND XRAY_T01.MNC_HN_NO = PATIENT_M01.MNC_HN_NO INNER JOIN "+
            //             "PATIENT_M02 ON PATIENT_M01.MNC_PFIX_CDT = PATIENT_M02.MNC_PFIX_CD INNER JOIN "+
            //             "XRAY_M01 ON XRAY_T05.MNC_XR_CD = XRAY_M01.MNC_XR_CD; ";
            sql = "SELECT XRAY_T01.MNC_HN_NO, PATIENT_M02.MNC_PFIX_DSC, PATIENT_M01.MNC_FNAME_T, PATIENT_M01.MNC_LNAME_T, " +
                    "PHARMACY_M01.MNC_PH_CD, PHARMACY_M01.MNC_PH_TN, XRAY_M01.MNC_XR_DSC, XRAY_T01.MNC_REQ_STS, FINANCE_M02.MNC_FN_TYP_DSC, "+
                     "XRAY_T05.MNC_XR_USE, XRAY_T05.MNC_XR_BAD " +
                    "FROM            XRAY_T05 INNER JOIN " +
                    "XRAY_T01 ON XRAY_T05.MNC_REQ_YR = XRAY_T01.MNC_REQ_YR AND XRAY_T05.MNC_REQ_NO = XRAY_T01.MNC_REQ_NO INNER JOIN " +
                    "PHARMACY_M01 ON XRAY_T05.MNC_PH_CD = PHARMACY_M01.MNC_PH_CD INNER JOIN " +
                    "PATIENT_M01 ON XRAY_T01.MNC_HN_YR = PATIENT_M01.MNC_HN_YR AND XRAY_T01.MNC_HN_NO = PATIENT_M01.MNC_HN_NO INNER JOIN " +
                    "PATIENT_M02 ON PATIENT_M01.MNC_PFIX_CDT = PATIENT_M02.MNC_PFIX_CD INNER JOIN " +
                    "XRAY_M01 ON XRAY_T05.MNC_XR_CD = XRAY_M01.MNC_XR_CD INNER JOIN " +
                    "FINANCE_M02 ON XRAY_T01.MNC_FN_TYP_CD = FINANCE_M02.MNC_FN_TYP_CD "+
                    "Where XRAY_T01.mnc_req_dat >= #"+dateStart.ToString("yyyy-MM-dd")+"# and XRAY_T01.mnc_req_dat <= #"+ dateEnd.ToString("yyyy-MM-dd")+"#";
            dt = conn.selectData(sql);
            return dt;
        }
    }
}
