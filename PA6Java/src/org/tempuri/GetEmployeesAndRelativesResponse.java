/**
 * GetEmployeesAndRelativesResponse.java
 *
 * This file was auto-generated from WSDL
 * by the Apache Axis 1.4 Apr 22, 2006 (06:55:48 PDT) WSDL2Java emitter.
 */

package org.tempuri;

public class GetEmployeesAndRelativesResponse  implements java.io.Serializable {
    private org.tempuri.GetEmployeesAndRelativesResponseGetEmployeesAndRelativesResult getEmployeesAndRelativesResult;

    public GetEmployeesAndRelativesResponse() {
    }

    public GetEmployeesAndRelativesResponse(
           org.tempuri.GetEmployeesAndRelativesResponseGetEmployeesAndRelativesResult getEmployeesAndRelativesResult) {
           this.getEmployeesAndRelativesResult = getEmployeesAndRelativesResult;
    }


    /**
     * Gets the getEmployeesAndRelativesResult value for this GetEmployeesAndRelativesResponse.
     * 
     * @return getEmployeesAndRelativesResult
     */
    public org.tempuri.GetEmployeesAndRelativesResponseGetEmployeesAndRelativesResult getGetEmployeesAndRelativesResult() {
        return getEmployeesAndRelativesResult;
    }


    /**
     * Sets the getEmployeesAndRelativesResult value for this GetEmployeesAndRelativesResponse.
     * 
     * @param getEmployeesAndRelativesResult
     */
    public void setGetEmployeesAndRelativesResult(org.tempuri.GetEmployeesAndRelativesResponseGetEmployeesAndRelativesResult getEmployeesAndRelativesResult) {
        this.getEmployeesAndRelativesResult = getEmployeesAndRelativesResult;
    }

    private java.lang.Object __equalsCalc = null;
    public synchronized boolean equals(java.lang.Object obj) {
        if (!(obj instanceof GetEmployeesAndRelativesResponse)) return false;
        GetEmployeesAndRelativesResponse other = (GetEmployeesAndRelativesResponse) obj;
        if (obj == null) return false;
        if (this == obj) return true;
        if (__equalsCalc != null) {
            return (__equalsCalc == obj);
        }
        __equalsCalc = obj;
        boolean _equals;
        _equals = true && 
            ((this.getEmployeesAndRelativesResult==null && other.getGetEmployeesAndRelativesResult()==null) || 
             (this.getEmployeesAndRelativesResult!=null &&
              this.getEmployeesAndRelativesResult.equals(other.getGetEmployeesAndRelativesResult())));
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
        if (getGetEmployeesAndRelativesResult() != null) {
            _hashCode += getGetEmployeesAndRelativesResult().hashCode();
        }
        __hashCodeCalc = false;
        return _hashCode;
    }

    // Type metadata
    private static org.apache.axis.description.TypeDesc typeDesc =
        new org.apache.axis.description.TypeDesc(GetEmployeesAndRelativesResponse.class, true);

    static {
        typeDesc.setXmlType(new javax.xml.namespace.QName("http://tempuri.org/", ">GetEmployeesAndRelativesResponse"));
        org.apache.axis.description.ElementDesc elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("getEmployeesAndRelativesResult");
        elemField.setXmlName(new javax.xml.namespace.QName("http://tempuri.org/", "GetEmployeesAndRelativesResult"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://tempuri.org/", ">>GetEmployeesAndRelativesResponse>GetEmployeesAndRelativesResult"));
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
