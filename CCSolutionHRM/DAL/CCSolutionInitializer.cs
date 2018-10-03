﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using CCSolutionHRM.Models;

namespace CCSolutionHRM.DAL
{
    public class CCSolutionInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<CCSolutionContext>
    {
        protected override void Seed(CCSolutionContext context)
        {
            /*
            var company = new List<Company>
            {
            new Company{Address="",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",DialingCode=971,EmailAddress="",Name="CCSolution",PhoneNumber=""
            ,UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="",Url="",Deleted=false}
            };

            company.ForEach(s => context.Companys.Add(s));
            context.SaveChanges();

            var gender = new List<Gender>
            {
            new Gender{CreationBy=1, CreationDate = DateTime.Now, CreationIP="",Delete=false,Name="Male",UpdationBy=1, UpdationDate=DateTime.Now, UpdationIP=""},
            new Gender{CreationBy=1, CreationDate = DateTime.Now, CreationIP="",Delete=false,Name="Female",UpdationBy=1, UpdationDate=DateTime.Now, UpdationIP=""}
            };

            gender.ForEach(s => context.Genders.Add(s));
            context.SaveChanges();

            var nationality = new List<Nationality>
            {
            new Nationality { CountryCode="AB",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=840,Name="Abkhazia",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="AF",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=93,Name="Afghanistan",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="AL",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=355,Name="Albania",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="Dz",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=213,Name="Algeria",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="AS",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=1684,Name="American Samoa",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="AD",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=376,Name="Andorra",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="AO",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=244,Name="Angola",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="AI",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=1264,Name="Anguilla",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="AQ",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=672,Name="Antarctica",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="Ag",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=1268,Name="Antigua And Barbuda",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="ab",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=1268,Name="Antigua And Barbuda",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="AR",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=54,Name="Argentina",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="AM",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=374,Name="Armenia",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="AW",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=297,Name="Aruba",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="AU",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=61,Name="Australia",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="AT",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=43,Name="Austria",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="AZ",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=994,Name="Azerbaijan",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="BS",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=1242,Name="Bahamas",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="BH",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=973,Name="Bahrain",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="BD",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=880,Name="Bangladesh",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="BB",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=1246,Name="Barbados",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="BY",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=375,Name="Belarus",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="BE",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=32,Name="Belgium",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="BZ",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=501,Name="Belize",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="Bj",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=229,Name="Benin",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="Bm",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=1441,Name="Bermuda",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="BT",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=975,Name="Bhutan",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="BO",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=591,Name="Bolivia",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="BA",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=387,Name="Bosnia And Herzegovina",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="Bw",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=267,Name="Botswana",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="BR",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=55,Name="Brazil",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="BN",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=673,Name="Brunei",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="BG",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=359,Name="Bulgaria",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="Bf",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=266,Name="Burkina Faso",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="MM",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=95,Name="Burma (Myanmar)",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="BI",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=257,Name="Burundi",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="KH",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=855,Name="Cambodia",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="CM",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=237,Name="Cameroon",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="CA",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=1,Name="Canada",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="Cv",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=238,Name="Cape Verde",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="Ky",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=1345,Name="Cayman Islands",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="CF",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=236,Name="Central African Republic",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="TD",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=235,Name="Chad",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="CL",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=56,Name="Chile",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="CN",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=86,Name="China",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="CO",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=57,Name="Colombia",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="KM",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=269,Name="Comoros",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="Ck",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=682,Name="Cook Islands",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="CR",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=506,Name="Costa Rica",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="HR",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=385,Name="Croatia",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="CU",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=53,Name="Cuba",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="CY",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=357,Name="Cyprus",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="CZ",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=420,Name="Czech Republic",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="CD",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=243,Name="Democratic Republic Of The Congo",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="DK",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=45,Name="Denmark",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="Dj",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=253,Name="Djibouti",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="DM",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=1767,Name="Dominica",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="Dr",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=1809,Name="Dominican Republic",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="DR",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=1809,Name="Dominican Republic Ii",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="Do",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=1849,Name="Dominican Republic Iii",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="EC",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=593,Name="Ecuador",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="Eg",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=20,Name="Egypt",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="SV",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=503,Name="El Salvador",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="Er",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=291,Name="Enitrea",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="GQ",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=240,Name="Equatorial Guinea",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="EE",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=372,Name="Estonia",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="Et",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=251,Name="Ethiopia",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="Fk",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=500,Name="Falkland Islands",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="FO",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=298,Name="Faroe Islands",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="FJ",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=679,Name="Fiji",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="FI",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=358,Name="Finland",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="FR",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=33,Name="France",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="GF",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=594,Name="French Guiana",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="PF",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=689,Name="French Polynesia",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="GA",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=241,Name="Gabon",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="Gm",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=220,Name="Gambia",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="GE",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=995,Name="Georgia",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="DE",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=49,Name="Germany",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="Gh",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=233,Name="Ghana",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="GI",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=350,Name="Gibraltar",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="GR",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=30,Name="Greece",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="Gl",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=299,Name="Greenland",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="GD",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=1473,Name="Grenada",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="Gu",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=1671,Name="Guam",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="GT",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=502,Name="Guatemala",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="Gn",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=224,Name="Guinea",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="Gw",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=245,Name="Guinea Bissau",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="GY",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=592,Name="Guyana",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="HT",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=509,Name="Haiti",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="HN",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=504,Name="Honduras",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="HK",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=852,Name="Hong Kong",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="HU",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=36,Name="Hungary",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="IS",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=354,Name="Iceland",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="IN",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=91,Name="India",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="ID",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=62,Name="Indonesia",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="XA",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=999,Name="Invalid Country Xa",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="IR",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=98,Name="Iran",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="IQ",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=964,Name="Iraq",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="IE",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=353,Name="Ireland",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="IL",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=972,Name="Israel",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="IT",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=39,Name="Italy",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="Ci",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=225,Name="Ivory Coast",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="JM",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=1876,Name="Jamaica",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="JP",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=81,Name="Japan",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="JO",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=962,Name="Jordan",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="KZ",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=7,Name="Kazakhstan",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="KE",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=254,Name="Kenya",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="Ki",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=686,Name="Kiribati",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="KW",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=965,Name="Kuwait",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="KG",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=996,Name="Kyrgyzstan",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="LA",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=856,Name="Laos",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="LV",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=371,Name="Latvia",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="LB",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=961,Name="Lebanon",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="Lr",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=231,Name="Liberia",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="Ly",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=218,Name="Libya",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="LI",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=423,Name="Liechtenstein",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="LT",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=370,Name="Lithuania",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="LU",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=352,Name="Luxembourg",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="MO",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=853,Name="Macau",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="MK",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=389,Name="Macedonia",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="MG",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=261,Name="Madagascar",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="Mw",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=265,Name="Malawi",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="MY",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=60,Name="Malaysia",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="MV",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=960,Name="Maldives",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="Ml",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=223,Name="Mali",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="MT",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=356,Name="Malta",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="Mh",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=692,Name="Marshall Islands",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="Mr",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=222,Name="Mauritania",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="Mu",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=230,Name="Mauritius",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="Yt",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=262,Name="Mayotte",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="Mx",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=1505,Name="Mexico",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="Fm",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=691,Name="Micronesia",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="MD",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=373,Name="Moldova",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="MC",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=377,Name="Monaco",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="MN",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=976,Name="Mongolia",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="ME",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=382,Name="Montenegro",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="Ms",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=1664,Name="Montserrat",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="Ma",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=212,Name="Morocco",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="Mz",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=258,Name="Mozambique",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="Na",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=264,Name="Namibia",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="NR",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=674,Name="Nauru",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="NP",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=977,Name="Nepal",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="NL",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=31,Name="Netherlands",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="An",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=599,Name="Netherlands Antilles",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="NC",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=687,Name="New Caledonia",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="NZ",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=64,Name="New Zealand",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="NI",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=505,Name="Nicaragua",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="Ne",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=227,Name="Niger",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="Ng",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=234,Name="Nigeria",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="NU",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=683,Name="Niue",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="KP",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=850,Name="North Korea",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="MP",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=1670,Name="Northern Mariana Islands",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="NO",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=47,Name="Norway",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="OM",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=968,Name="Oman",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="PK",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=92,Name="Pakistan",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="Pw",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=680,Name="Palau",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="GS",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=970,Name="Palestinian Territory, Occupied",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="PA",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=507,Name="Panama",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="Pg",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=675,Name="Papua New Guinea",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="PY",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=595,Name="Paraguay",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="PE",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=51,Name="Peru",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="PH",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=63,Name="Philippines",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="PN",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=870,Name="Pitcairn Islands",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="PL",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=48,Name="Poland",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="PT",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=351,Name="Portugal",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="PR",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=1787,Name="Puerto Rico",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="Pr",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=1939,Name="Puerto Rico",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="QA",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=974,Name="Qatar",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="CG",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=242,Name="Republic Of The Congo",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="RO",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=40,Name="Romania",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="RU",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=7,Name="Russia",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="Rw",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=250,Name="Rwanda",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="BL",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=590,Name="Saint Barthelemy",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="Sh",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=290,Name="Saint Helena",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="KN",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=1869,Name="Saint Kitts And Nevis",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="LC",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=1758,Name="Saint Lucia",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="PM",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=508,Name="Saint Pierre And Miquelon",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="VC",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=1784,Name="Saint Vincent And The Grenadines",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="WS",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=685,Name="Samoa",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="SM",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=378,Name="San Marino",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="ST",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=239,Name="Sao Tome And Principe",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="SA",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=966,Name="Saudi Arabia",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="Sn",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=221,Name="Senegal",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="RS",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=381,Name="Serbia",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="Sc",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=248,Name="Seychelles",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="Sl",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=232,Name="Sierra Leone",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="SG",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=65,Name="Singapore",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="SK",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=421,Name="Slovakia",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="SI",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=386,Name="Slovenia",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="Sb",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=677,Name="Solomon Island",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="So",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=252,Name="Somalia",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="Za",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=27,Name="South Africa",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="KR",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=82,Name="South Korea",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="Ss",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=211,Name="South Sudan",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="ES",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=34,Name="Spain",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="LK",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=94,Name="Sri Lanka",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="Sd",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=249,Name="Sudan",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="SR",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=597,Name="Suriname",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="Sz",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=268,Name="Swaziland",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="SE",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=46,Name="Sweden",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="CH",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=41,Name="Switzerland",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="SY",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=963,Name="Syria",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="TW",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=886,Name="Taiwan",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="TJ",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=992,Name="Tajikistan",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="Tz",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=255,Name="Tanzania",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="TH",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=66,Name="Thailand",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="TL",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=670,Name="Timor-Leste",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="Tg",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=228,Name="Togo",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="TK",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=690,Name="Tokelau",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="TO",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=676,Name="Tonga",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="TT",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=1868,Name="Trinidad And Tobago",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="Tn",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=216,Name="Tunisia",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="TR",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=90,Name="Turkey",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="TM",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=993,Name="Turkmenistan",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="Tc",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=1649,Name="Turks And Caicos Islands",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="TV",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=688,Name="Tuvalu",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="Ug",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=256,Name="Uganda",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="UA",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=380,Name="Ukraine",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="AE",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=971,Name="United Arab Emirates",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="GB",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=44,Name="United Kingdom",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="US",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=1,Name="United States",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="UY",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=598,Name="Uruguay",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="UZ",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=998,Name="Uzbekistan",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="VU",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=678,Name="Vanuatu",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="VE",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=58,Name="Venezuela",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="VN",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=84,Name="Vietnam",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="VG",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=1284,Name="Virgin Islands, British",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="VI",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=1340,Name="Virgin Islands, U.S.",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="WF",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=681,Name="Wallis And Futuna",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="YE",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=967,Name="Yemen",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="Zm",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=260,Name="Zambia",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" },
            new Nationality { CountryCode="Zw",CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DialingCode=263,Name="Zimbabwe",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP="" }

            };

            nationality.ForEach(s => context.Nationalitys.Add(s));
            context.SaveChanges();

            var document = new List<Document>
            {
            new Document{CreationBy=1, CreationDate = DateTime.Now, CreationIP="",Delete=false,Name="NIC",UpdationBy=1, UpdationDate=DateTime.Now, UpdationIP=""},
            new Document{CreationBy=1, CreationDate = DateTime.Now, CreationIP="",Delete=false,Name="PassPort",UpdationBy=1, UpdationDate=DateTime.Now, UpdationIP=""},
            new Document{CreationBy=1, CreationDate = DateTime.Now, CreationIP="",Delete=false,Name="Visa",UpdationBy=1, UpdationDate=DateTime.Now, UpdationIP=""},
            new Document{CreationBy=1, CreationDate = DateTime.Now, CreationIP="",Delete=false,Name="Education",UpdationBy=1, UpdationDate=DateTime.Now, UpdationIP=""}
            };

            document.ForEach(s => context.Documents.Add(s));
            context.SaveChanges();

            var employee = new List<Employee>
            {
            new Employee{EmailAddress="dua2004@gmail.com",CompanyId=1,CreationBy=1,CreationDate=DateTime.Now,CreationIP="",CurrentAddress="",DateOfBirth=DateTime.Now.AddYears(-36),Delete=false,DialingCode1=92,DialingCode2=92,GenderId=1,
            Name="Muhammad Rizwan",NationalityId=1,PermenantAddress="",PhoneNumber1="3222999643",PhoneNumber2="3222999643",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP=""},
            new Employee{EmailAddress="sabir@gmail.com",CompanyId=1,CreationBy=1,CreationDate=DateTime.Now,CreationIP="",CurrentAddress="",DateOfBirth=DateTime.Now.AddYears(-36),Delete=false,DialingCode1=92,DialingCode2=92,GenderId=1,
            Name="Muhammad Sabir",NationalityId=1,PermenantAddress="",PhoneNumber1="3222999665",PhoneNumber2="3222999665",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP=""}
            };

            employee.ForEach(s => context.Employees.Add(s));
            context.SaveChanges();

            var employeedocument = new List<EmployeeDocument>
            {
            new EmployeeDocument{Comments="NIC #",UpdationIP="",UpdationDate=DateTime.Now,UpdationBy=1,CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DocumentId=1,DocumentNumber="42101-1612323-9",EmployeeId=1
            ,ExpiryDate=DateTime.Now.AddYears(5),IssueDate=DateTime.Now.AddYears(-2),NationalityId=1,PhysicalLocation=""},
            new EmployeeDocument{Comments="Passport #",UpdationIP="",UpdationDate=DateTime.Now,UpdationBy=1,CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DocumentId=2,DocumentNumber="CH9893221",EmployeeId=1
            ,ExpiryDate=DateTime.Now.AddYears(5),IssueDate=DateTime.Now.AddYears(-2),NationalityId=1,PhysicalLocation=""},
            new EmployeeDocument{Comments="Visa #",UpdationIP="",UpdationDate=DateTime.Now,UpdationBy=1,CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DocumentId=3,DocumentNumber="CH98254821",EmployeeId=1
            ,ExpiryDate=DateTime.Now.AddYears(5),IssueDate=DateTime.Now.AddYears(-2),NationalityId=1,PhysicalLocation=""},
            new EmployeeDocument{Comments="SSC #",UpdationIP="",UpdationDate=DateTime.Now,UpdationBy=1,CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DocumentId=4,DocumentNumber="123456",EmployeeId=1
            ,ExpiryDate=DateTime.Now.AddYears(5),IssueDate=DateTime.Now.AddYears(-2),NationalityId=1,PhysicalLocation=""},
            new EmployeeDocument{Comments="HSC #",UpdationIP="",UpdationDate=DateTime.Now,UpdationBy=1,CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DocumentId=4,DocumentNumber="123456",EmployeeId=1
            ,ExpiryDate=DateTime.Now.AddYears(5),IssueDate=DateTime.Now.AddYears(-2),NationalityId=1,PhysicalLocation=""},
            new EmployeeDocument{Comments="Bachlors Degree #",UpdationIP="",UpdationDate=DateTime.Now,UpdationBy=1,CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DocumentId=4,DocumentNumber="123456",EmployeeId=1
            ,ExpiryDate=DateTime.Now.AddYears(5),IssueDate=DateTime.Now.AddYears(-2),NationalityId=1,PhysicalLocation=""},
            new EmployeeDocument{Comments="Masters Degree #",UpdationIP="",UpdationDate=DateTime.Now,UpdationBy=1,CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DocumentId=4,DocumentNumber="123456",EmployeeId=1
            ,ExpiryDate=DateTime.Now.AddYears(5),IssueDate=DateTime.Now.AddYears(-2),NationalityId=1,PhysicalLocation=""},

            new EmployeeDocument{Comments="NIC #",UpdationIP="",UpdationDate=DateTime.Now,UpdationBy=1,CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DocumentId=1,DocumentNumber="42101-1611234-9",EmployeeId=2
            ,ExpiryDate=DateTime.Now.AddYears(5),IssueDate=DateTime.Now.AddYears(-2),NationalityId=1,PhysicalLocation=""},
            new EmployeeDocument{Comments="Passport #",UpdationIP="",UpdationDate=DateTime.Now,UpdationBy=1,CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DocumentId=2,DocumentNumber="CH9892221",EmployeeId=2
            ,ExpiryDate=DateTime.Now.AddYears(5),IssueDate=DateTime.Now.AddYears(-2),NationalityId=1,PhysicalLocation=""},
            new EmployeeDocument{Comments="Visa #",UpdationIP="",UpdationDate=DateTime.Now,UpdationBy=1,CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DocumentId=3,DocumentNumber="CH92363221",EmployeeId=2
            ,ExpiryDate=DateTime.Now.AddYears(5),IssueDate=DateTime.Now.AddYears(-2),NationalityId=1,PhysicalLocation=""},
            new EmployeeDocument{Comments="SSC #",UpdationIP="",UpdationDate=DateTime.Now,UpdationBy=1,CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DocumentId=4,DocumentNumber="1234565",EmployeeId=2
            ,ExpiryDate=DateTime.Now.AddYears(5),IssueDate=DateTime.Now.AddYears(-2),NationalityId=1,PhysicalLocation=""},
            new EmployeeDocument{Comments="HSC #",UpdationIP="",UpdationDate=DateTime.Now,UpdationBy=1,CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DocumentId=4,DocumentNumber="1234565",EmployeeId=2
            ,ExpiryDate=DateTime.Now.AddYears(5),IssueDate=DateTime.Now.AddYears(-2),NationalityId=1,PhysicalLocation=""},
            new EmployeeDocument{Comments="Bachlors Degree #",UpdationIP="",UpdationDate=DateTime.Now,UpdationBy=1,CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DocumentId=4,DocumentNumber="1234565",EmployeeId=2
            ,ExpiryDate=DateTime.Now.AddYears(5),IssueDate=DateTime.Now.AddYears(-2),NationalityId=1,PhysicalLocation=""},
            new EmployeeDocument{Comments="Masters Degree #",UpdationIP="",UpdationDate=DateTime.Now,UpdationBy=1,CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,DocumentId=4,DocumentNumber="1234565",EmployeeId=2
            ,ExpiryDate=DateTime.Now.AddYears(5),IssueDate=DateTime.Now.AddYears(-2),NationalityId=1,PhysicalLocation=""}
            };

            employeedocument.ForEach(s => context.EmployeeDocuments.Add(s));
            context.SaveChanges();

            var user = new List<Users>
            {
                new Users{CreationBy=1,CreationDate=DateTime.Now,CreationIP="",Delete=false,LoginId="rizwanahmad",Name="Muhammad Rizwan",Password="Axact123",UpdationBy=1,UpdationDate=DateTime.Now,UpdationIP=""}
            };
            user.ForEach(s => context.Userss.Add(s));
            context.SaveChanges();
             */
        }
    }
}