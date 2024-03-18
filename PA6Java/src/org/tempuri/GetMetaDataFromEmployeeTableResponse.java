/**
 * GetMetaDataFromEmployeeTableResponse.java
 *
 * This file was auto-generated from WSDL
 * by the Apache Axis 1.4 Apr 22, 2006 (06:55:48 PDT) WSDL2Java emitter.
 */

package org.tempuri;

public class GetMetaDataFromEmployeeTableResponse  implements java.io.Serializable {
    private org.tempuri.GetMetaDataFromEmployeeTableResponseGetMetaDataFromEmployeeTableResult getMetaDataFromEmployeeTableResult;

    public GetMetaDataFromEmployeeTableResponse() {
    }

    public GetMetaDataFromEmployeeTableResponse(
           org.tempuri.GetMetaDataFromEmployeeTableResponseGetMetaDataFromEmployeeTableResult getMetaDataFromEmployeeTableResult) {
           this.getMetaDataFromEmployeeTableResult = getMetaDataFromEmployeeTableResult;
    }


    /**
     * Gets the getMetaDataFromEmployeeTableResult value for this GetMetaDataFromEmployeeTableResponse.
     * 
     * @return getMetaDataFromEmployeeTableResult
     */
    public org.tempuri.GetMetaDataFromEmployeeTableResponseGetMetaDataFromEmployeeTableResult getGetMetaDataFromEmployeeTableResult() {
        return getMetaDataFromEmployeeTableResult;
    }


    /**
     * Sets the getMetaDataFromEmployeeTableResult value for this GetMetaDataFromEmployeeTableResponse.
     * 
     * @param getMetaDataFromEmployeeTableResult
     */
    public void setGetMetaDataFromEmployeeTableResult(org.tempuri.GetMetaDataFromEmployeeTableResponseGetMetaDataFromEmployeeTableResult getMetaDataFromEmployeeTableResult) {
        this.getMetaDataFromEmployeeTableResult = getMetaDataFromEmployeeTableResult;
    }

    private java.lang.Object __equalsCalc = null;
    public synchronized boolean equals(java.lang.Object obj) {
        if (!(obj instanceof GetMetaDataFromEmployeeTableResponse)) return false;
        GetMetaDataFromEmployeeTableResponse other = (GetMetaDataFromEmployeeTableResponse) obj;
        if (obj == null) return false;
        if (this == obj) return true;
        if (__equalsCalc != null) {
            return (__equalsCalc == obj);
        }
        __equalsCalc = obj;
        boolean _equals;
        _equals = true && 
            ((this.getMetaDataFromEmployeeTableResult==null && other.getGetMetaDataFromEmployeeTableResult()==null) || 
             (this.getMetaDataFromEmployeeTableResult!=null &&
              this.getMetaDataFromEmployeeTableResult.equals(other.getGetMetaDataFromEmployeeTableResult())));
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
        if (getGetMetaDataFromEmployeeTableResult() != null) {
            _hashCode += getGetMetaDataFromEmployeeTableResult().hashCode();
        }
        __hashCodeCalc = false;
        return _hashCode;
    }

    // Type metadata
    private static org.apache.axis.description.TypeDesc typeDesc =
        new org.apache.axis.description.TypeDesc(GetMetaDataFromEmployeeTableResponse.class, true);

    static {
        typeDesc.setXmlType(new javax.xml.namespace.QName("http://tempuri.org/", ">GetMetaDataFromEmployeeTableResponse"));
        org.apache.axis.description.ElementDesc elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("getMetaDataFromEmployeeTableResult");
        elemField.setXmlName(new javax.xml.namespace.QName("http://tempuri.org/", "GetMetaDataFromEmployeeTableResult"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://tempuri.org/", ">>GetMetaDataFromEmployeeTableResponse>GetMetaDataFromEmployeeTableResult"));
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
