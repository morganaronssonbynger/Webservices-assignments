/**
 * GetTableConstraintsResponse.java
 *
 * This file was auto-generated from WSDL
 * by the Apache Axis 1.4 Apr 22, 2006 (06:55:48 PDT) WSDL2Java emitter.
 */

package org.tempuri;

public class GetTableConstraintsResponse  implements java.io.Serializable {
    private org.tempuri.GetTableConstraintsResponseGetTableConstraintsResult getTableConstraintsResult;

    public GetTableConstraintsResponse() {
    }

    public GetTableConstraintsResponse(
           org.tempuri.GetTableConstraintsResponseGetTableConstraintsResult getTableConstraintsResult) {
           this.getTableConstraintsResult = getTableConstraintsResult;
    }


    /**
     * Gets the getTableConstraintsResult value for this GetTableConstraintsResponse.
     * 
     * @return getTableConstraintsResult
     */
    public org.tempuri.GetTableConstraintsResponseGetTableConstraintsResult getGetTableConstraintsResult() {
        return getTableConstraintsResult;
    }


    /**
     * Sets the getTableConstraintsResult value for this GetTableConstraintsResponse.
     * 
     * @param getTableConstraintsResult
     */
    public void setGetTableConstraintsResult(org.tempuri.GetTableConstraintsResponseGetTableConstraintsResult getTableConstraintsResult) {
        this.getTableConstraintsResult = getTableConstraintsResult;
    }

    private java.lang.Object __equalsCalc = null;
    public synchronized boolean equals(java.lang.Object obj) {
        if (!(obj instanceof GetTableConstraintsResponse)) return false;
        GetTableConstraintsResponse other = (GetTableConstraintsResponse) obj;
        if (obj == null) return false;
        if (this == obj) return true;
        if (__equalsCalc != null) {
            return (__equalsCalc == obj);
        }
        __equalsCalc = obj;
        boolean _equals;
        _equals = true && 
            ((this.getTableConstraintsResult==null && other.getGetTableConstraintsResult()==null) || 
             (this.getTableConstraintsResult!=null &&
              this.getTableConstraintsResult.equals(other.getGetTableConstraintsResult())));
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
        if (getGetTableConstraintsResult() != null) {
            _hashCode += getGetTableConstraintsResult().hashCode();
        }
        __hashCodeCalc = false;
        return _hashCode;
    }

    // Type metadata
    private static org.apache.axis.description.TypeDesc typeDesc =
        new org.apache.axis.description.TypeDesc(GetTableConstraintsResponse.class, true);

    static {
        typeDesc.setXmlType(new javax.xml.namespace.QName("http://tempuri.org/", ">GetTableConstraintsResponse"));
        org.apache.axis.description.ElementDesc elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("getTableConstraintsResult");
        elemField.setXmlName(new javax.xml.namespace.QName("http://tempuri.org/", "GetTableConstraintsResult"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://tempuri.org/", ">>GetTableConstraintsResponse>GetTableConstraintsResult"));
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
