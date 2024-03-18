/**
 * GetTablesMethodOneResponse.java
 *
 * This file was auto-generated from WSDL
 * by the Apache Axis 1.4 Apr 22, 2006 (06:55:48 PDT) WSDL2Java emitter.
 */

package org.tempuri;

public class GetTablesMethodOneResponse  implements java.io.Serializable {
    private org.tempuri.GetTablesMethodOneResponseGetTablesMethodOneResult getTablesMethodOneResult;

    public GetTablesMethodOneResponse() {
    }

    public GetTablesMethodOneResponse(
           org.tempuri.GetTablesMethodOneResponseGetTablesMethodOneResult getTablesMethodOneResult) {
           this.getTablesMethodOneResult = getTablesMethodOneResult;
    }


    /**
     * Gets the getTablesMethodOneResult value for this GetTablesMethodOneResponse.
     * 
     * @return getTablesMethodOneResult
     */
    public org.tempuri.GetTablesMethodOneResponseGetTablesMethodOneResult getGetTablesMethodOneResult() {
        return getTablesMethodOneResult;
    }


    /**
     * Sets the getTablesMethodOneResult value for this GetTablesMethodOneResponse.
     * 
     * @param getTablesMethodOneResult
     */
    public void setGetTablesMethodOneResult(org.tempuri.GetTablesMethodOneResponseGetTablesMethodOneResult getTablesMethodOneResult) {
        this.getTablesMethodOneResult = getTablesMethodOneResult;
    }

    private java.lang.Object __equalsCalc = null;
    public synchronized boolean equals(java.lang.Object obj) {
        if (!(obj instanceof GetTablesMethodOneResponse)) return false;
        GetTablesMethodOneResponse other = (GetTablesMethodOneResponse) obj;
        if (obj == null) return false;
        if (this == obj) return true;
        if (__equalsCalc != null) {
            return (__equalsCalc == obj);
        }
        __equalsCalc = obj;
        boolean _equals;
        _equals = true && 
            ((this.getTablesMethodOneResult==null && other.getGetTablesMethodOneResult()==null) || 
             (this.getTablesMethodOneResult!=null &&
              this.getTablesMethodOneResult.equals(other.getGetTablesMethodOneResult())));
        __equalsCalc = null;
        return _equals;
    }

    private boolean __hashCodeCalc = false;
    public synchronized int hashCode() {
        if (__hashCodeCalc) {
            return 0;
        }
        __hashCodeCalc = true;
        int _hashCode = 1;
        if (getGetTablesMethodOneResult() != null) {
            _hashCode += getGetTablesMethodOneResult().hashCode();
        }
        __hashCodeCalc = false;
        return _hashCode;
    }

    // Type metadata
    private static org.apache.axis.description.TypeDesc typeDesc =
        new org.apache.axis.description.TypeDesc(GetTablesMethodOneResponse.class, true);

    static {
        typeDesc.setXmlType(new javax.xml.namespace.QName("http://tempuri.org/", ">GetTablesMethodOneResponse"));
        org.apache.axis.description.ElementDesc elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("getTablesMethodOneResult");
        elemField.setXmlName(new javax.xml.namespace.QName("http://tempuri.org/", "GetTablesMethodOneResult"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://tempuri.org/", ">>GetTablesMethodOneResponse>GetTablesMethodOneResult"));
        elemField.setMinOccurs(0);
        elemField.setNillable(false);
        typeDesc.addFieldDesc(elemField);
    }

    /**
     * Return type metadata object
     */
    public static org.apache.axis.description.TypeDesc getTypeDesc() {
        return typeDesc;
    }

    /**
     * Get Custom Serializer
     */
    public static org.apache.axis.encoding.Serializer getSerializer(
           java.lang.String mechType, 
           java.lang.Class _javaType,  
           javax.xml.namespace.QName _xmlType) {
        return 
          new  org.apache.axis.encoding.ser.BeanSerializer(
            _javaType, _xmlType, typeDesc);
    }

    /**
     * Get Custom Deserializer
     */
    public static org.apache.axis.encoding.Deserializer getDeserializer(
           java.lang.String mechType, 
           java.lang.Class _javaType,  
           javax.xml.namespace.QName _xmlType) {
        return 
          new  org.apache.axis.encoding.ser.BeanDeserializer(
            _javaType, _xmlType, typeDesc);
    }

}
