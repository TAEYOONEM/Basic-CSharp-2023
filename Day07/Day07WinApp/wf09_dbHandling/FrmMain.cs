﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient; // SQL server용 DB연결 클라이언트 네임스페이스
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf09_dbHandling
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            // 1. 연결문자열 생성
            string connectionstring = "Data Source=localhost;Initial Catalog=Northwind;Persist Security Info=True;User ID=sa; Password = 12345;";
            // 2. DB 연결을 통해서 Connection 객체를 생성
            SqlConnection conn = new SqlConnection(connectionstring); // 연결문자열 없이 객체 생성X , 첫번쨰 방법
            //conn.ConnectionString = connectionstring; // 두번째 방법

            // 3. 객체를 통해서 DB연결
            conn.Open();

            // 4. DB 처리를 위한 쿼리 작성
            // 5. SqlDataAdapter 생성
            string selQuery = @"SELECT CustomerID
                                     , CompanyName
                                     , ContactName
                                     , ContactTitle
                                     , Address
                                     , City
                                     , Region
                                     , PostalCode
                                     , Country
                                     , Phone
                                     , Fax
                                FROM dbo.Customers";
            //SqlCommand selCmd = new SqlCommand(selQuery, conn);
            //selCmd.Connection = conn;
            SqlDataAdapter adapter = new SqlDataAdapter(selQuery, conn);

            // 패스 리더객체 생성, 값을 넘겨줌
            //SqlDataReader reader = selCmd.ExecuteReader();

            // 패스 데이터리더에 있는 데이터를 데이터셋으로 보내기
            //DataSet ds = new DataSet();

            // 6, 데이터 셋으로 전달
            DataSet ds = new DataSet(); // 테이블 여러개 담을 수 있음
            adapter.Fill(ds);

            // 7. 데이터 그리드 뷰에 바인딩하기 위한 BindingSource 생성
            BindingSource source = new BindingSource();

            // 7. 데이터 그리드 뷰의 DataSource에 데이터 셋을 할당
            source.DataSource = ds.Tables[0];
            DgvNorthWind.DataSource = source;   
            
            // 8. DB close
            conn.Close();

        }
    }
}
