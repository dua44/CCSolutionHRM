<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
>
  <xsl:output method="xml" indent="yes" encoding="utf-8"/>

  <xsl:template match="/Menus">
    <ul>
      <xsl:attribute name="class">
        <xsl:text>root</xsl:text>
      </xsl:attribute>
      <xsl:attribute name="id">
        <xsl:text>nav</xsl:text>
      </xsl:attribute>
      <xsl:call-template name="MenuListing" />
    </ul>
  </xsl:template>

  <xsl:template match="/Menus" >
    <ul>
      <xsl:attribute name="class">
        <xsl:text>first</xsl:text>
      </xsl:attribute>
      <xsl:attribute name="id">
        <xsl:text>nav</xsl:text>
      </xsl:attribute>
      <xsl:call-template name="subMenuListing" />
    </ul>
  </xsl:template>

  <!-- Allow for recusive child node processing -->
  <xsl:template name="MenuListing">
    <xsl:apply-templates select="Menu" />
  </xsl:template>

  <xsl:template name="subMenuListing">
    <xsl:apply-templates select="Menu" />
  </xsl:template>

  <xsl:template match="Menu">
    <xsl:if test="IsViewableInMenu='true'">
    <li >
 
        <xsl:if test="count(Menu) > 0 ">
          <xsl:attribute name="class">
            <xsl:text>slideRight</xsl:text>
          </xsl:attribute>
        </xsl:if>

        <a>
          <!--   Convert Menu child elements to <li> <a> html tags and  add attributes inside <a> tag -->
          <xsl:attribute name="href">
            <xsl:value-of select="Url"/>
          </xsl:attribute>
          <xsl:value-of select="Name"/>
          <i>
            <xsl:attribute name="class">
              <xsl:value-of select="MenuClass"/>
              <xsl:text>-default</xsl:text>
            </xsl:attribute>
            <xsl:text disable-output-escaping="yes"> <![CDATA[&nbsp;]]></xsl:text>
          </i>
          <i>
            <xsl:attribute name="class">
              <xsl:value-of select="MenuClass"/>
              <xsl:text>-active</xsl:text>
            </xsl:attribute>
            <xsl:text disable-output-escaping="yes"> <![CDATA[&nbsp;]]></xsl:text>
          </i>
        </a>
        <!-- Call MenuListing if there are child Menu nodes  -->
        <xsl:if test="count(Menu) > 0 ">
          <ul class="subMenu scrlable">
            <xsl:call-template name="subMenuListing" />
          </ul>
        </xsl:if>

    </li>
  </xsl:if>
  </xsl:template>
</xsl:stylesheet>
