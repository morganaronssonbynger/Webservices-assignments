/**
 * GetTablesMethodTwoResponse.java
 *
 * This file was auto-generated from WSDL
 * by the Apache Axis 1.4 Apr 22, 2006 (06:55:48 PDT) WSDL2Java emitter.
 */

package org.tempuri;

public class GetTablesMethodTwoResponse  implements java.io.Serializable {
    private org.tempuri.GetTablesMethodTwoResponseGetTablesMethodTwoResult getTablesMethodTwoResult;

    public GetTablesMethodTwoResponse() {
    }

    public GetTablesMethodTwoResponse(
           org.tempuri.GetTablesMethodTwoResponseGetTablesMethodTwoResult getTablesMethodTwoResult) {
           this.getTablesMethodTwoResult = getTablesMethodTwoResult;
    }


    /**
     * Gets the getTablesMethodTwoResult value for this GetTablesMethodTwoResponse.
     * 
     * @return getTablesMethodTwoResult
     */
    public org.tempuri.GetTablesMethodTwoResponseGetTablesMethodTwoResult getGetTablesMethodTwoResult() {
        return getTablesMethodTwoResult;
    }


    /**
     * Sets the getTablesMethodTwoResult value for this GetTablesMethodTwoResponse.
     * 
     * @param getTablesMethodTwoResult
     */
    public void setGetTablesMethodTwoResult(org.tempuri.GetTablesMethodTwoResponseGetTablesMethodTwoResult getTablesMethodTwoResult) {
        this.getTablesMethodTwoResult = getTablesMethodTwoResult;
    }

    private java.lang.Object __equalsCalc = null;
    public synchronized boolean equals(java.lang.Object obj) {
        if (!(obj instanceof GetTablesMethodTwoResponse)) return false;
        GetTablesMethodTwoResponse other = (GetTablesMethodTwoResponse) obj;
        if (obj == null) return false;
        if (this == obj) return true;
        if (__equalsCalc != null) {
            return (__equalsCalc == obj);
        }
        __equalsCalc = obj;
        boolean _equals;
        _equals = true && 
            ((this.getTablesMethodTwoResult==null && other.getGetTablesMethodTwoResult()==null) || 
             (this.getTablesMethodTwoResult!=null &&
              this.getTablesMethodTwoResult.equals(other.getGetTablesMethodTwoResult())));
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
        if (getGetTablesMethodTwoResult() != null) {
            _hashCode += getGetTablesMethodTwoResult().hashCode();
        }
        __hashCodeCalc = false;
        return _hashCode;
    }

    // Type metadata
    private static org.apache.axis.description.TypeDesc typeDesc =
        new org.apache.axis.description.TypeDesc(GetTablesMethodTwoResponse.class, true);

    static {
        typeDesc.setXmlType(new javax.xml.namespace.QName("http://tempuri.org/", ">GetTablesMethodTwoResponse"));
        org.apache.axis.description.ElementDesc elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("getTablesMethodTwoResult");
        elemField.setXmlName(new javax.xml.namespace.QName("http://tempuri.org/", "GetTablesMethodTwoResult"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://tempuri.org/", ">>GetTablesMethodTwoResponse>GetTablesMethodTwoResult"));
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
